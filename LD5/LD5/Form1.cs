using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LD5
{
    public partial class Form1 : Form
    {
        const string CFd1 = "..\\..\\U17a.txt";
        const string CFd2 = "..\\..\\U17b.txt";
        const string CRfv = "..\\..\\U17rez.txt";

        Sarasas<Keliautojas> K = new Sarasas<Keliautojas>();
        Sarasas<Viesbuciai> V = new Sarasas<Viesbuciai>();

        public Form1()
        {
            InitializeComponent();
        }

        public  void SkaitytiKeliautoja(string fv, ref Sarasas<Keliautojas> K)
        {
            using (var failas = new StreamReader(fv))
            {
                string eilute;
                while ((eilute = failas.ReadLine()) != null)
                {
                    string[] parts = eilute.Split(';');
                    string pavardė = parts[0];
                    string pavadinimas = parts[1];
                    string tipas = parts[2];
                    int nakvynes = int.Parse(parts[3]);
                    Keliautojas k = new Keliautojas(pavardė, pavadinimas, tipas, nakvynes);
                    K.DetiDuomenisA(k);
                }
            }
        }

        public void SkaitytiViesbuti(string fv, ref Sarasas<Viesbuciai> K)
        {
            using (var failas = new StreamReader(fv))
            {
                string eilute;
                while ((eilute = failas.ReadLine()) != null)
                {
                    string[] parts = eilute.Split(';');
                    string pavadinimas = parts[0];
                    string tipas = parts[1];
                    decimal kaina = decimal.Parse(parts[2]);
                    Viesbuciai k = new Viesbuciai (pavadinimas, tipas, kaina);
                    V.DetiDuomenisA(k);
                }
            }
        }

        public void SpausdintiKeliautoja(string fv, Sarasas<Keliautojas> K, string koment)
        {
            using (var failas = new StreamWriter(fv, true))
            {
                failas.WriteLine(koment);
                string b = new string('-', 50);
                failas.WriteLine(b);
                failas.WriteLine("| Pavarde| Viešbutis | Tipas | Nakvynės");
                failas.WriteLine(b);
                for (K.Pradzia(); K.Yra(); K.Kitas())
                {
                    failas.WriteLine("{0}", K.ImtiDuomenis().ToString());
                }
                failas.WriteLine(b);
                failas.WriteLine();
            }
        }

        public void SpausdintiViesbuti(string fv, Sarasas<Viesbuciai> V, string koment)
        {
            using (var failas = new StreamWriter(fv, true))
            {
                failas.WriteLine(koment);
                string b = new string('-', 50);
                failas.WriteLine(b);
                failas.WriteLine("| Viešbutis | Tipas | Kaina");
                failas.WriteLine(b);
                for (V.Pradzia(); V.Yra(); V.Kitas())
                {
                    failas.WriteLine("{0}", V.ImtiDuomenis().ToString());
                }
                failas.WriteLine(b);
                failas.WriteLine();
            }
        }


        private void skaitytiKeliautojusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkaitytiKeliautoja(CFd1, ref K);
        }

        private void išvestiKeliautojusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpausdintiKeliautoja(CRfv, K, "Keliautojų sąrašas");
        }

        private void skaitytiViešbučiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkaitytiViesbuti(CFd2, ref V);
        }

        private void išvestiViešbučiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpausdintiViesbuti(CRfv, V, "Viešbučių sąrašas");
        }
    }
}
