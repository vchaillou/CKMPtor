using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class EtatRentrée : EtatFourmi
    {
        public static EtatRentrée GetInstance { get; } = new EtatRentrée();

        private EtatRentrée()
        {
            // Pattern singleton
        }

        public int DéposerPheromone(int unPoidsPheromone)
        {
            return 0;
        }
    }
}
