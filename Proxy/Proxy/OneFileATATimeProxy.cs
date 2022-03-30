using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    static class OneFileATATimeProxy
    {
        static readonly object FileInUse = new object();

        public static void AppendAllText(string filename, string text)
        {
            lock (FileInUse)
            {
                File.AppendAllText(filename, text);
            }
        }
    }
}
