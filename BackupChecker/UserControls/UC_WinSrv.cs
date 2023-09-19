﻿using System;
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

namespace BackupChecker
{
    public partial class UC_WinSrv : UserControl
    {
        XDocument config;

        public UC_WinSrv(XDocument config)
        {
            InitializeComponent();

            this.config = config;

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
            var dataElements = config.Descendants("data");

            // Iteruj przez elementy "data"
            foreach (var dataElement in dataElements)
            {
                // Pobierz wartości ścieżki i nazwy
                string dirPath = dataElement.Element("dirPath").Value;
                string name = dataElement.Element("name").Value;

                // Tworzenie tekstu do wyświetlenia w ListBox
                string listItemText = $"{dirPath} - {name}";

                // Dodawanie pozycji do ListBox
                listBox1.Items.Add(listItemText);
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

            List<CheckBox> checkBoxList = new List<CheckBox>
            {
                ChBMo,
                ChBTu,
                ChBWe,
                ChBTh,
                ChBFr,
                ChBSa,
                ChBSu
            };


            /// sprawdzanie czy istnieje taka sama sciezka w pliku 
            bool pathExist = config.Descendants("dirPath")
                                    .Any(node => node.Value == path);


            /// Jeśli NIE istnieje taka ścieżka w pliku
            if (appSettingsNode != null && !pathExist)
            {
                appSettingsNode.Add(new XElement("data",
                                        new XElement("dirPath", textBox1.Text),
                                        new XElement("name", textBox2.Text),
                                        new XElement("difference", difference.Text),
                                        xmlRoot));

                foreach(CheckBox chb in checkBoxList)
                {
                    if (chb.Checked) { xmlRoot.Add(new XElement("day", chb.Text)); }
                }

                config.Save("appconfig.xml");
            }
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
    }
}