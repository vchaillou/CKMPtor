using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    public class Fourmi : Personnage
    {
        public EtatFourmi Etat { get; set; }
        public StrategieDeplacement Strategie { get; set; }
        public int poidsPheromone { get; set; }

        public Parcelle Position { get; set; }

        public override void JouerTour()
        {
            Strategie.Déplacer(this);
        }

        public override void AnalyseSituation()
        {
            throw new NotImplementedException();
        }

        public int DeposerPheromone()
        {
            return Etat.DéposerPheromone(poidsPheromone);
        }
    }
}
