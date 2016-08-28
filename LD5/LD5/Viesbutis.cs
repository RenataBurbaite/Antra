using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD5
{
    abstract public class Viesbutis
    {
        public string pavadinimas { get; set; }
        public string tipas { get; set; }
        

        public Viesbutis() { }

        public Viesbutis(string viešbutis, string tipas)
        {
            this.pavadinimas = viešbutis;
            this.tipas = tipas;
        }

        public override string ToString()
        {
            string eilute;
            eilute = string.Format("{0} {1}", pavadinimas, tipas);
            return eilute;
        }
    }
}
