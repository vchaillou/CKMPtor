using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class Objectif : Objet
    {
        public int poids { get; }

        public override void JouerTour()
        {
            // Rien à faire
        }

        public Objectif(int unPoids)
        {
            poids = unPoids;
        }
    }
}
