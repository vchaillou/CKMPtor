using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CKMPtor
{
    public class Cellule : Personnage
    {
        public EtatCellule État { get; set; }
        public EtatCellule ProchainÉtat { get; set; }
        public Case CelluleZone { get; set; }

        public override void JouerTour()
        {
            État = ProchainÉtat;
        }

        public override void AnalyseSituation()
        {
            État.Strategie.Exécuter(this);
        }

        public Cellule(EtatCellule unÉtat)
        {
            État = unÉtat;
            ProchainÉtat = unÉtat;
            CelluleZone = null;
        }
    }
}
