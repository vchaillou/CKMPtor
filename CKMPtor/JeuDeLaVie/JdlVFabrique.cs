using System;
using CKMPtor.Xml;

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

        public Simulateur CréerSimulateur()
        {
            Simulateur unSimulateur = new Simulateur();

            DonnéesInitialeSimulateurs donnéesXML = DonnéesXML.Réccupérer();

            Random rand = new Random();

            int longueur = donnéesXML.JeuDeLaVie.Carte.Longeur;
            int largeur = donnéesXML.JeuDeLaVie.Carte.Largeur;

            Case[,] cases = new Case[longueur, largeur];

            for (int i = 0; i < longueur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    cases[i, j] = new Case(new Cellule(rand.Next(0, 1000) % 3 == 0 ? EtatCellule.VIVANTE : EtatCellule.MORTE));
                    unSimulateur.AjouterZone(cases[i, j]);
                    unSimulateur.AjouterPersonnage(cases[i, j].Occupant);

                    if (i > 0)
                    {
                        unSimulateur.AjouterAccès(new Veine(cases[i, j], cases[i - 1, j]));
                    }

                    if (j > 0)
                    {
                        unSimulateur.AjouterAccès(new Veine(cases[i, j], cases[i, j - 1]));
                    }
                }
            }

            unSimulateur.Interfaces.Add(new InterfaceGraphiqueJeuDeLaVie(unSimulateur, longueur));
            unSimulateur.Play();
            return unSimulateur;
        }
    }
}