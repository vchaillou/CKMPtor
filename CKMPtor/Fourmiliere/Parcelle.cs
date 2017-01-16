using System.Collections.Generic;
using System.Windows.Documents;

namespace CKMPtor
{
    public class Parcelle : Zone
    {
        private Objet objet;
        private Simulateur simulateur;

        public void AjouterObjet(Objet unObjet)
        {
            objet = unObjet;
            simulateur.AjouterObjet(objet);
        }

        public Objet PrendreObjet()
        {
            return objet;
        }

        public void RetirerObjet()
        {
            objet = null;
        }

        public bool estVide()
        {
            return objet == null;
        }

        public Parcelle(Simulateur unSimulateur)
        {
            simulateur = unSimulateur;
        }
    }
}