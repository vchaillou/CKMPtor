using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    class DéplacementAller : StrategieDeplacement
    {
        public void Déplacer(Fourmi uneFourmi)
        {
            Random rand = new Random();
            Parcelle uneParcelle = uneFourmi.Position.Chemins.Cast<Tunnel>()
                .ElementAt(rand.Next(0, uneFourmi.Position.Chemins.Count))
                .autreBout(uneFourmi.Position) as Parcelle;

            uneFourmi.Position = uneParcelle;
        }
    }
}
