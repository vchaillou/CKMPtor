
using System;
using System.Linq;

namespace CKMPtor
{
    public abstract class StrategieCellule
    {
        public abstract void Exécuter(Cellule uneCellule);
    }

    public class StrategieMourir : StrategieCellule
    {
        public override void Exécuter(Cellule uneCellule)
        {
            int compteur = 0;
            foreach (Veine uneVeine in uneCellule.CelluleZone.Chemins)
            {
                compteur += (uneVeine.autreBout(uneCellule.CelluleZone).Occupant as Cellule).État == EtatCellule.VIVANTE
                    ? 1
                    : 0;
            }
            if (compteur < 2 || compteur > 3)
            {
                uneCellule.ProchainÉtat = EtatCellule.MORTE;
            }
            else
            {
                uneCellule.ProchainÉtat = EtatCellule.VIVANTE;
            }
        }
    }

    public class StrategieRevivre : StrategieCellule
    {
        public override void Exécuter(Cellule uneCellule)
        {
            int compteur = 0;
            foreach (Veine uneVeine in uneCellule.CelluleZone.Chemins)
            {
                compteur += (uneVeine.autreBout(uneCellule.CelluleZone).Occupant as Cellule).État == EtatCellule.VIVANTE
                    ? 1
                    : 0;
            }
            if (compteur == 3)
            {
                uneCellule.ProchainÉtat = EtatCellule.VIVANTE;
            }
            else
            {
                uneCellule.ProchainÉtat = EtatCellule.MORTE;
            }
        }
    }
}