using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupChecker.Data
{
    internal class Data_WinServ
    {
        internal string dirPath, name, difference;
        internal List<string> days = new List<string>();

        public Data_WinServ(string dirPath, string name, string difference, List<string> days) 
        { 
            this.dirPath = dirPath;
            this.name = name;
            this.difference = difference;
            this.days = days;
        }

        public override string ToString()
        {
            return $"{dirPath} - {name}";
        }

    }
}
