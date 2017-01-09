using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CKMPtor
{
    public class Simulateur
    {
        private EtatMajor etatMajor;
        public List<InterfaceGraphique> Interfaces { get; }
        public List<Zone> Zones { get; }
        public List<Personnage> Personnages { get; }
        public List<Objet> Objets { get; }
        public List<Accès> Accès { get; }

        public Simulateur()
        {
            Interfaces = new List<InterfaceGraphique>();
            Zones = new List<Zone>();
            Personnages = new List<Personnage>();
            Objets = new List<Objet>();
            Accès = new List<Accès>();
            etatMajor = new EtatMajor();
        }

        public void MettreAJourInterface()
        {
            foreach(InterfaceGraphique uneInterface in Interfaces)
            {
                uneInterface.Refresh();
            }
        }

        public void AjouterZone(Zone uneZone)
        {
            Zones.Add(uneZone);
        }

        public void AjouterPersonnage(Personnage unPersonnage)
        {
            Personnages.Add(unPersonnage);
            etatMajor.EnregistrerObservateur(unPersonnage);
        }

        public void AjouterObjet(Objet unObjet)
        {
            Objets.Add(unObjet);
            etatMajor.EnregistrerObservateur(unObjet);
        }

        public void AjouterAccès(Accès unAccès)
        {
            Accès.Add(unAccès);
        }

        public void Play()
        {
            // TODO => Threading
            while (true)
            {
                etatMajor.DonnerLesOrdres();
                MettreAJourInterface();
                Thread.Sleep(5000);
            }
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
