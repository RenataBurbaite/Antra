using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD5
{
    public class Viesbuciai : Viesbutis
    {
        decimal kaina { get; set; }
        public Viesbuciai() { }

        public Viesbuciai(string pavadinimas, string tipas, decimal kaina)
            : base(pavadinimas, tipas)
        {
            this.kaina = kaina;
        }

        public override string ToString()
        {
            string eilute;
            eilute = string.Format("{0} {1} {2}", base.ToString(), pavadinimas, tipas, kaina);
            return eilute;
        }
    }
}