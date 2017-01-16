using System.Collections.Generic;
using System.Windows.Documents;

namespace CKMPtor
{
    public class Parcelle : Zone
    {
        private Objet objet;

        public void AjouterObjet(Objet unObjet)
        {
            objet = unObjet;
        }

        public Objet PrendreObjet()
        {
            return objet;
        }

        public bool estVide()
        {
            return objet == null;
        }
    }
}