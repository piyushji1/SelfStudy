using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class FileWriter
    {
        public string filename= DateTime.Now.ToFileTime().ToString();
        public void WriteToFile(string line)=>
            File.AppendAllText(filename,line+Environment.NewLine);
    }
}
