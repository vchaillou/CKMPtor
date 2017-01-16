using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class Pheromone : Objet
    {
        public int poids { get; set; }

        public override void JouerTour()
        {
            if(poids > 0) poids--;
        }

        public Pheromone()
        {
            poids = 0;
        }
    }
}
