using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class DéplacementAller : StrategieDeplacement
    {
        private static Random rand = new Random();

        public static DéplacementAller GetInstance { get; }= new DéplacementAller();

        private DéplacementAller()
        {
            // Pattern singleton
        }

        public void Déplacer(Fourmi uneFourmi)
        {
            if (uneFourmi.Position.Chemins.Count(x => x.autreBout(uneFourmi.Position).Occupant == null) == 0)
            {
                return;
            }

            Parcelle uneParcelle = uneFourmi.Position.Chemins.Cast<Tunnel>().Where(x => x.autreBout(uneFourmi.Position).Occupant == null)
                .ElementAt(rand.Next(0, uneFourmi.Position.Chemins.Count(x => x.autreBout(uneFourmi.Position).Occupant == null)))
                .autreBout(uneFourmi.Position) as Parcelle;

            uneFourmi.Position = uneParcelle;

            if (uneFourmi.Position.PrendreObjet() is Fourmiliere)
            {
                // Ne devrait pas arriver si les déplacements n'étaient pas aléatoires
                return;
            }
            if (uneFourmi.Position.PrendreObjet() is Objectif)
            {
                uneFourmi.Strategie = DéplacementRetour.GetInstance;
            }
        }
    }
}
