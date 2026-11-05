using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Carte
    {
        public string titlu;
        public string autor;
        public int pagini;
        public double pret;
        public int exemplare;
        public bool disponibila;
        public string cititor;

        public double ValoareTotala()
        {
            return exemplare * pret;
        }

        public string RandDeLista()
        {
            return titlu + " (" + autor + ") - " +
                   exemplare + " ex. - " +
                   ValoareTotala() + " lei";
        }


        public Carte(string titlu, string autor, int pagini,
                     double pret, int exemplare,
                     bool disponibila, string cititor)
        {
            this.titlu = titlu;
            this.autor = autor;
            this.pagini = pagini;
            this.pret = pret;
            this.exemplare = exemplare;
            this.disponibila = disponibila;
            this.cititor = cititor;
        }
        public Carte(string linie)
        {
            string[] v = linie.Split('#');

            titlu = v[0];
            autor = v[1];
            pagini = int.Parse(v[2]);
            pret = double.Parse(v[3]);
            exemplare = int.Parse(v[4]);
            disponibila = bool.Parse(v[5]);
            cititor = v[6];
        }
    }
}


    

