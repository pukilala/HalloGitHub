using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloGitHub
{
    /// <summary>
    /// Klasse zur eingaben und ausgaben Kontrolle
    /// </summary>
    class IO_Control
    {
        private ListPersonen lp = new ListPersonen();

        public void findTest()
        {
            lp.addPreson(new Person(1111, "luki"));
            Person p = lp.getPerson(1111);
            lp.delPerson(p);
            p = lp.getPerson(1111);
            int i = 0;

        }
    }
}
