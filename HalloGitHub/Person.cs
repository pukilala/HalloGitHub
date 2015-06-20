using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloGitHub
{
    class Person
    {
        private string name;
        private int matNr;
        public Person() { }
        public Person(int matNr, string name)
        {
            this.matNr = matNr;
            this.name = name;
        }
        public int MatNr
        {
            get { return matNr; }
            set { matNr = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
    }
}
