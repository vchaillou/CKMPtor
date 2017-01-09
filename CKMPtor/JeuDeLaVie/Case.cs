using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    // Case
    // Composant de la matrice extracellulaire dans laquelle baignent les cellules
    public class Case : Zone
    {
        public Case(Cellule uneCellule)
        {
            Occupant = uneCellule;
            uneCellule.CelluleZone = this;
        }
    }
}
