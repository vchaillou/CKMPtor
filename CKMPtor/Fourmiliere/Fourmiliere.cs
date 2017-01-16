using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class Fourmiliere : Objet
    {
        private Simulateur simulateur;
        private Parcelle parcelle; // Parcelle de départ

        public override void JouerTour()
        {
            foreach (Fourmi uneFourmi in simulateur.Personnages.Cast<Fourmi>())
            {
                if (uneFourmi.Position == null) uneFourmi.Position = parcelle;
                if (uneFourmi.Position == parcelle)
                {
                    uneFourmi.Strategie = DéplacementAller.GetInstance;
                    uneFourmi.Etat = EtatDehors.GetInstance;
                }
            }
        }

        public Fourmiliere(Simulateur unSimulateur, Parcelle uneParcelle)
        {
            simulateur = unSimulateur;
            parcelle = uneParcelle;
        }
    }
}
