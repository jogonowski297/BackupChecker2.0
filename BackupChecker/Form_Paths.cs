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

namespace BackupChecker
{
    public partial class Form_Paths : UserControl
    {
        XDocument config;
        string configFile = "appconfig.xml";

        public Form_Paths()
        {
            InitializeComponent();
            if (File.Exists(configFile))
            {
                string path = Path.GetFullPath(configFile);
                config = XDocument.Load("appconfig.xml");
            }
            else
            {
                // Tworzenie nowego pliku, jeśli nie istnieje
                XDocument newXmlDoc = new XDocument(
                    new XElement("configuration",
                        new XElement("appSettings")
                    )
                );

                newXmlDoc.Save(configFile);
            }

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

            XElement appSettingsNode = config.Descendants("appSettings").FirstOrDefault();

            /// sprawdzanie czy istnieje taka sama sciezka w pliku 
            bool pathExist = config.Descendants("dirPath")
                                    .Any(node => node.Value == path);

            if (appSettingsNode != null && !pathExist)
            {
                appSettingsNode.Add(new XElement("dirPath", textBox1.Text));
                config.Save("appconfig.xml");
            }


        }

        private void Load_Click(object sender, EventArgs e)
        {
            XElement secondDirPathNode = config.Descendants("dirPath").ElementAtOrDefault(1);
            if (secondDirPathNode != null)
            {
                textBox2.Text = "DSADASD";

            }
        }


    }
}
