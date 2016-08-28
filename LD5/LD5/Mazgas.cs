using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD5
{
        public sealed class Mazgas<Viesbutis>
        {
            public Viesbutis Duomenys { get; set; }
            public Mazgas<Viesbutis> Kitas { get; set; }
            public Mazgas() { }
            public Mazgas(Viesbutis duomenys, Mazgas<Viesbutis> adresas)
            {
                this.Duomenys = duomenys;
                this.Kitas = adresas;
            }
        }
}
