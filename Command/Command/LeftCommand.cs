﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class LeftCommand : ICommand
    {
        public void Invoke()
        {
            Console.WriteLine("Up");
            Program.x--;
        }
    }
}
