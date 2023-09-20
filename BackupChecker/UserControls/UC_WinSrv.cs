using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml.Linq;
using System.Xml;
using BackupChecker.Data;
using BackupCheckerConsole;

namespace BackupChecker
{
    public partial class UC_WinSrv : UserControl
    {
        XDocument config;

        List<CheckBox> checkBoxList;

        public UC_WinSrv(XDocument config)
        {
            InitializeComponent();

            this.config = config;

            checkBoxList = new List<CheckBox>
            {
                ChBMo,
                ChBTu,
                ChBWe,
                ChBTh,
                ChBFr,
                ChBSa,
                ChBSu
            };

            LoadToList();

        }

        private void AddKeyToConfiguration(string sectionName, string key, string value)
        {
            try
            {
                // Pobierz pełną ścieżkę do pliku app.config
                string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app.config");

                // Otwórz plik app.config
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFilePath };
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);


                if (config.GetSection(sectionName) == null)
                {
                    // Dodaj nową sekcję, jeśli nie istnieje
                    config.Sections.Add(sectionName, new AppSettingsSection());
                }
                // Ustaw klucz i wartość w danej sekcji
                config.AppSettings.Settings.Add(key, value);

                // Zapisz zmiany i odśwież sekcję
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(sectionName);

            }
            catch (ConfigurationErrorsException ex)
            {
                // Obsługa błędów podczas zapisu
                textBox2.Text = ex.Message;
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }

        private void LoadToList()
        {
            listBox1.Items.Clear();

            var dataElements = config.Descendants("data");

            // Iteruj przez elementy "data"
            foreach (var dataElement in dataElements)
            {
                // Pobierz wartości ścieżki i nazwy
                string dirPath = dataElement.Element("dirPath").Value;
                string name = dataElement.Element("name").Value;
                string difference = dataElement.Element("difference").Value;

                List<string> days = dataElements
                    .Where(path => path.Element("dirPath").Value == dirPath)
                    .Descendants("selectedDays")
                    .Elements("day")
                    .Select(day => day.Value)
                    .ToList();

                Data_WinServ dataWinSrv = new Data_WinServ(dirPath, name, difference, days);

                // Dodawanie pozycji do ListBox
                listBox1.Items.Add(dataWinSrv);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog.SelectedPath;
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;

            XElement appSettingsNode = config.Descendants("directory").FirstOrDefault();

            XElement xmlRoot = new XElement("selectedDays");

            List<string> days = new List<string>();


            /// sprawdzanie czy istnieje taka sama sciezka
            bool pathExist = config.Descendants("dirPath")
                                    .Any(node => node.Value == path);



            if (appSettingsNode != null)
            {
                /// Jeśli NIE istnieje taka ścieżka 
                if (!pathExist)
                {
                    appSettingsNode.Add(new XElement("data",
                                        new XElement("dirPath", textBox1.Text),
                                        new XElement("name", textBox2.Text),
                                        new XElement("difference", difference.Text),
                                        xmlRoot));

                    foreach (CheckBox chb in checkBoxList)
                    {
                        if (chb.Checked)
                        {
                            xmlRoot.Add(new XElement("day", chb.Text));
                            days.Add(chb.Text);
                        }
                    }


                }
                /// Jeśli istnieje taka ścieżka 
                else
                {
                    var dataElements = config.Descendants("data");

                    XElement oldName = dataElements.Where(p => p.Element("dirPath").Value == path).Elements("name").First();
                    oldName.Value = textBox2.Text;
                }

                config.Save("appconfig.xml");
            }

            LoadToList();


        }


        private void difference_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Data_WinServ selectedObject = (Data_WinServ)listBox1.SelectedItem;

                if (selectedObject != null)
                {
                    textBox1.Text = selectedObject.dirPath;
                    textBox2.Text = selectedObject.name;
                    difference.Text = selectedObject.difference;


                    foreach (CheckBox chb in checkBoxList)
                    {
                        if (selectedObject.days.Contains(chb.Text))
                        {
                            chb.Checked = true;
                        }
                        else
                        {
                            chb.Checked = false;
                        }
                    }


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
