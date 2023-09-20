using BackupCheckerConsole.Check;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BackupCheckerConsole
{
    internal class Program
    {
        static XDocument config;
        private const string configFile = "appconfig.xml";

        static void Main(string[] args)
        {
            if (!File.Exists("C:\\Users\\jakub.ogonowski\\Documents\\C#\\BackupChecker2.0\\BackupChecker\\bin\\Debug\\net6.0-windows\\appconfig.xml"))
            {
                MessageBox.Show("Brak pliku appconfig.xml \nProgram zostanie wyłączony");
                Environment.Exit(0);
            }

            config = XDocument.Load("C:\\Users\\jakub.ogonowski\\Documents\\C#\\BackupChecker2.0\\BackupChecker\\bin\\Debug\\net6.0-windows\\appconfig.xml");


            Ch_WinServ winSrv = new Ch_WinServ(config.Descendants("directory").First());

            winSrv.CheckDirectory();

        }



    }
}
