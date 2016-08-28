using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD5
{
   public class Keliautojas : Viesbutis
    {
       string pavardė { get; set; }
       int nakvynės { get; set; }
       
        public Keliautojas () {}

        public Keliautojas (string pavardė, string pavadinimas, string tipas, int nakvynes) : base (pavadinimas, tipas)
            {
                this.pavardė = pavardė;
                this.nakvynės = nakvynės;
            }


         public override string ToString() 
         { 
            string eilute;
            //eilute = string.Format("{0} {1} {2}", pavardė, base.ToString(), pavadinimas, tipas, nakvynės);
            eilute = string.Format("{0} {1} {2}", pavardė, base.ToString(), nakvynės); 
            return eilute; 
        }
    }
}
