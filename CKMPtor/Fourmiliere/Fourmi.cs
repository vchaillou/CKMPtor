using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    public class Fourmi : Personnage
    {
        private Parcelle _position;
        public EtatFourmi Etat { get; set; }
        public StrategieDeplacement Strategie { get; set; }
        private int poidsPheromone;

        public Parcelle Position
        {
            get { return _position; }
            set
            {
                if(Position != null) Position.Occupant = null;
                _position = value;
                Position.Occupant = this;
            }
        }

        public override void JouerTour()
        {
            Strategie.Déplacer(this);
        }

        public override void AnalyseSituation()
        {
            // Pas nécessaire
        }

        public int DeposerPheromone()
        {
            return Etat.DéposerPheromone(poidsPheromone);
        }

        public Fourmi(int unPoidsPheromone)
        {
            Strategie = DéplacementRetour.GetInstance;
            Etat = EtatRentrée.GetInstance;
            poidsPheromone = unPoidsPheromone;
        }
    }
}
