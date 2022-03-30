using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ListReader
    {
        public delegate void NewListItem(string listItem);
        public event NewListItem ListUpdated;
        public void ReadList()
        {
            while (true)
            {
                var listItem=Console.ReadLine();
                ListUpdated?.Invoke(listItem);
            }
        }
    }
}
