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
        public void addPerson(int matnr, string name)
        {
            kunden.Add(new Person(matnr, name));
        }
        public void delPerson(Person p)
        {
            kunden.Remove(p);
        }
        public Person getPerson(int mat)
        {
            return kunden.Find(x => x.MatNr == mat);
        }

        public int getNextMatNr() 
        {
            int newMat = -1;
            foreach (Person p in kunden)
            {
                if (newMat < p.MatNr)
                    newMat = p.MatNr;
                return newMat;
            }
        }
    }
}
