using System;
using System.Linq;

namespace CKMPtor
{
    internal class InterfaceGraphiqueJeuDeLaVie : InterfaceGraphique
    {
        private int longueurLigne;

        public InterfaceGraphiqueJeuDeLaVie(Simulateur unSimulateur, int uneLongueurLigne) : base(unSimulateur)
        {
            longueurLigne = uneLongueurLigne;
        }

        public override void Refresh()
        {
            int bip = 0;
            foreach (Case uneCase in simulation.Zones.Cast<Case>())
            {
                Console.Write((uneCase.Occupant as Cellule).État == EtatCellule.VIVANTE ? "*" : " ");
                if (++bip == longueurLigne)
                {
                    Console.WriteLine("");
                    bip = 0;
                }
            }
            
        }
    }
}