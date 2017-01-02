using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor
{
    public class Simulateur
    {
        private FabriqueAbstraite fabrique;

        private EtatMajor etatMajor;
        private List<InterfaceGraphique> interfaces;
        private List<Zone> zones;
        private List<Personnage> personnages;
        private List<Objet> objets;
        private List<Accès> accès;

        public Simulateur(FabriqueAbstraite uneFabrique)
        {
            interfaces = new List<InterfaceGraphique>();
            System.Windows.MessageBox.Show("TODO : Ajout interface graphique");
            etatMajor = new EtatMajor();
            fabrique = uneFabrique;
        }

        public void MettreAJourInterface()
        {
            foreach(InterfaceGraphique uneInterface in interfaces)
            {
                uneInterface.Refresh();
            }
        }

        public void AjouterZone()
        {
            zones.Add(fabrique.CréerZone());
        }

        public void AjouterPersonnage()
        {
            personnages.Add(fabrique.CréerPersonnage(etatMajor));
        }

        public void AjouterObjet()
        {
            objets.Add(fabrique.CréerObjet(etatMajor));
        }

        public void AjouterAccès()
        {
            accès.Add(fabrique.CréerAccès());
        }

        public void Play()
        {
            // TODO => faire une boucle
            etatMajor.DonnerLesOrdres();
            MettreAJourInterface();
        }
        public void Pause()
        {
            // TODO
        }

        public void Retour()
        {
            // TODO
        }
    }
}
