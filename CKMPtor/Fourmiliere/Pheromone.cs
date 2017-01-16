using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    public class Pheromone : Objet
    {
        public int poids { get; set; }
        private Parcelle parcelle;

        public override void JouerTour()
        {
            if (poids > 0) poids--;
            if (poids <= 0)
            {
                parcelle.RetirerObjet();
            }
        }

        public Pheromone(Parcelle uneParcelle)
        {
            parcelle = uneParcelle;
            poids = 0;
        }
    }
}
