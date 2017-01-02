using System;

namespace CKMPtor
{
    public class JdlVFabrique : FabriqueAbstraite
    {
        public string Nom
        {
            get
            {
                return "Jeu de la vie";
            }
        }

        public Accès CréerAccès()
        {
            throw new NotImplementedException();
        }
        
        public Objet CréerObjet(EtatMajor unEtatMajor)
        {
            throw new NotImplementedException();
        }

        public Personnage CréerPersonnage(EtatMajor unEtatMajor)
        {
            throw new NotImplementedException();
        }

        public Simulateur CréerSimulateur()
        {
            Simulateur unSimulateur = new Simulateur(this);
            System.Windows.MessageBox.Show("TODO : Parsing XML");
            System.Windows.MessageBox.Show("TODO : Ajout zones, accès, personnages, etc...");
            return unSimulateur;
        }

        public Zone CréerZone()
        {
            throw new NotImplementedException();
        }
    }
}