using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCheckerConsole.Check.Single
{
    internal class S_WinServ
    {
        string path;
        string name;
        int difference;
        List<string> days;

        public S_WinServ(string path, string name, int difference, List<string> days)
        {
            this.path = path;
            this.name = name;
            this.difference = difference;
            this.days = days;
        }

        public override string ToString()
        {
            return path;
        }
    }
}
