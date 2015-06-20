using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloGitHub
{
    class ListPersonen
    {
        private List<Person> kunden = new List<Person>();

        public void addPreson(Person p)
        {
            kunden.Add(p);
        }
        public void delPerson(Person p)
        {
            kunden.Remove(p);
        }
        public Person getPerson(int mat)
        {
            return kunden.Find(x => x.MatNr == mat);
        }
    }
}
