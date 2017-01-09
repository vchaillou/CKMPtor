using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    public class EtatMajor
    {
        private HashSet<Observateur> observateurs;

        public void EnregistrerObservateur(Observateur unObservateur)
        {
            observateurs.Add(unObservateur);
        }

        public void SupprimerObservateur(Observateur unObservateur)
        {
            observateurs.Remove(unObservateur);
        }

        public EtatMajor()
        {
            observateurs = new HashSet<Observateur>();
        }

        public void DonnerLesOrdres()
        {
            foreach (Personnage personnage in observateurs.OfType<Personnage>())
            {
                personnage.AnalyseSituation();
            }
            foreach(Observateur observateur in observateurs)
            {
                observateur.JouerTour();
            }
        }
    }
}
