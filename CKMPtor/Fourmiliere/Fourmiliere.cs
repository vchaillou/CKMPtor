using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class Fourmiliere : Objet
    {
        private int nombreFourmis;

        public override void JouerTour()
        {
            while (nombreFourmis > 0)
            {
                System.Windows.MessageBox.Show("TODO : Ajout fourmi");
            }
        }

        public Fourmiliere(int unNombreFourmis)
        {
            nombreFourmis = unNombreFourmis;
        }
    }
}
