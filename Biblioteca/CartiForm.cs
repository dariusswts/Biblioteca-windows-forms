using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca
{
    public partial class CartiForm : Form
    {

        List<Carte> lista = new List<Carte>();


        public CartiForm()
        {
            InitializeComponent();
        }

        private void CartiForm_Load(object sender, EventArgs e)
        {
            IncarcaFisier();
        }

        private void IncarcaFisier()
        {
            StreamReader streamreader = new StreamReader("Carti.txt");

            streamreader.ReadLine();
            string linie;

            while ((linie = streamreader.ReadLine()) != null)
            {
                if (linie != "")
                {
                    lista.Add(new Carte(linie));
                }
            }

            
        }
        

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lstCarti.Items.Clear();

            int disponibile = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                lstCarti.Items.Add(lista[i].RandDeLista());

                if (lista[i].disponibila == true)
                {
                    disponibile++;
                }
            }

            lblStare.Text = lista.Count + " carti, " +
                            disponibile + " disponibile";
        }
    }
}
