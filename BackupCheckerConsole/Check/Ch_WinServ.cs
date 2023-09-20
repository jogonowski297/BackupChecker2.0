using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BackupCheckerConsole.Check
{
    internal class Ch_WinServ
    {

        XElement directories;

        /// <summary>
        /// All directories (<directory></directory>)
        /// </summary>
        /// <param name="directories"></param>
        public Ch_WinServ(XElement directories)
        {
            this.directories = directories;
        }

        private bool CheckPathExist(XElement path)
        {

            if (!Directory.Exists(path.Value))
            {
                Console.WriteLine("Katalog " + path.Value + " nie istnieje");
                return false;
            }
            return true;
        }

        public void CheckDirectory()
        {
            List<XElement> datas = directories.Elements("data").ToList();

            foreach (XElement data in datas)
            {
                XElement path = data.Element("dirPath");
                XElement name = data.Element("name");
                XElement difference = data.Element("difference");
                List<XElement> days = data.Elements("selectedDays").Elements("day").ToList();

                if(CheckPathExist(path))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(path.Value);
                    
                }
            }

        }



    }
}
