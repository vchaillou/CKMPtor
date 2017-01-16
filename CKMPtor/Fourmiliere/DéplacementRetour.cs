using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class DéplacementRetour : StrategieDeplacement
    {
        private static Random rand = new Random();

        public static DéplacementRetour GetInstance { get; } = new DéplacementRetour();

        private DéplacementRetour()
        {
            // Pattern singleton
        }

        public void Déplacer(Fourmi uneFourmi)
        {
            if (uneFourmi.Position == null || uneFourmi.Position.PrendreObjet() is Fourmiliere)
            {
                return;
            }

            if (uneFourmi.Position.Chemins.Count(x => x.autreBout(uneFourmi.Position).Occupant == null) == 0)
            {
                return;
            }
            
            Parcelle uneParcelle = uneFourmi.Position.Chemins.Cast<Tunnel>().Where(x => x.autreBout(uneFourmi.Position).Occupant == null)
                .ElementAt(rand.Next(0, uneFourmi.Position.Chemins.Count(x => x.autreBout(uneFourmi.Position).Occupant == null)))
                .autreBout(uneFourmi.Position) as Parcelle;

            uneFourmi.Position = uneParcelle;

            if (uneFourmi.Position.PrendreObjet() is Objectif)
            {
                // Ne devrait pas arriver si les déplacements n'étaient pas aléatoires
                return;
            }
            if (uneFourmi.Position.PrendreObjet() is Fourmiliere)
            {
                uneFourmi.Etat = EtatRentrée.GetInstance;
            }
            else if (uneFourmi.DeposerPheromone()>0)
            {
                if (uneFourmi.Position.estVide())
                {
                    uneFourmi.Position.AjouterObjet(new Pheromone(uneFourmi.Position));
                    (uneFourmi.Position.PrendreObjet() as Pheromone).poids += uneFourmi.DeposerPheromone();
                }
                else if (uneFourmi.Position.PrendreObjet() is Pheromone)
                {
                    (uneFourmi.Position.PrendreObjet() as Pheromone).poids += uneFourmi.DeposerPheromone();
                }
            }
            
        }
    }
}
