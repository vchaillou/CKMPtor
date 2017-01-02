using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    public interface FabriqueAbstraite
    {
        string Nom { get; }

        Accès CréerAccès();

        Objet CréerObjet(EtatMajor unEtatMajor);

        Personnage CréerPersonnage(EtatMajor unEtatMajor);

        Zone CréerZone();

        Simulateur CréerSimulateur();
    }
}
