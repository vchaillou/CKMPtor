using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class EtatDehors : EtatFourmi
    {
        public static EtatDehors GetInstance { get; } = new EtatDehors();

        private EtatDehors()
        {
            // Pattern singleton
        }

        public int DéposerPheromone(int unPoidsPheromone)
        {
            return unPoidsPheromone;
        }
    }
}
