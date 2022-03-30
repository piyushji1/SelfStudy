using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningException
{
    internal class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set {
                if(value == null)
                    throw new NullReferenceException("Name must have value");
                name = value;
            }
        }

    }
}
