using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BackupChecker
{
    public partial class UC_Settings : UserControl
    {
        XDocument config;


        public UC_Settings(XDocument config)
        {
            InitializeComponent();

            this.config = config;

            Load_Values();
        }

        private void Load_Values()
        {
            companyName.Text = this.config.Descendants("company").FirstOrDefault().Value;
        }

        private void Save_Click(object sender, EventArgs e)
        {

            bool companyExist = config.Descendants("company").Any(node => node.Value == companyName.Text);
            bool emailExist = config.Descendants("email").Any(node => node.Value == emailAddress.Text);
            bool hourExist = config.Descendants("hour").Any(node => node.Value == time.Value.ToString());
            bool smtpExist = config.Descendants("smtp").Any(node => node.Value == smtpClient.Text);
            bool portExist = config.Descendants("port").Any(node => node.Value == port.Text);
            bool usrExist = config.Descendants("username").Any(node => node.Value == username.Text);
            bool passExist = config.Descendants("password").Any(node => node.Value == password.Text);
            bool sslExist = config.Descendants("ssl").Any(node => node.Value == ssl.Text);

            if (!companyExist) { config.Descendants("company").FirstOrDefault().Value = companyName.Text; }
            if (!emailExist) { config.Descendants("email").FirstOrDefault().Value = emailAddress.Text; }
            if (!hourExist) { 

                config.Descendants("hour").FirstOrDefault().Value = time.Value.Hour.ToString();
                config.Descendants("minute").FirstOrDefault().Value = time.Value.Minute.ToString();

            }
            if (!smtpExist) { config.Descendants("smtp").FirstOrDefault().Value = smtpClient.Text; }
            if (!portExist) { config.Descendants("port").FirstOrDefault().Value = port.Text; }
            if (!usrExist) { config.Descendants("username").FirstOrDefault().Value = username.Text; }
            if (!passExist) { config.Descendants("password").FirstOrDefault().Value = password.Text; }
            if (!sslExist) { config.Descendants("ssl").FirstOrDefault().Value = ssl.Text; }
            
            config.Save("appconfig.xml");

        }
    }
}
