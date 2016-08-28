using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD5
{

    public sealed class Sarasas<T>
    {
        Mazgas<T> pr;
        Mazgas<T> d; 

        public Sarasas()
        {
            this.pr = null;
            this.d = null;
        }
  
        public void Pradzia()
        {
            d = pr;
        }

        public void Kitas()
        {
            d = d.Kitas;
        }

        public bool Yra()
        {
            return d != null;
        }

        public T ImtiDuomenis() { return d.Duomenys; }
    
        public void DetiDuomenisA(T inf)
        {
            pr = new Mazgas<T>(inf, pr);
        }
    }
}