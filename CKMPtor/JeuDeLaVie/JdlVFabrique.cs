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

        public Simulateur CréerSimulateur()
        {
            Simulateur unSimulateur = new Simulateur();
            System.Windows.MessageBox.Show("TODO : Parsing XML");

            Random rand = new Random();

            int longueur, largeur;

            // A changer
            longueur = 10;
            largeur = 10;

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

            // TODO
            if (unSimulateur.Personnages.Count < 150)
            {
                // choisir case random
                // ajouter cellules vivantes
            }

            unSimulateur.Interfaces.Add(new InterfaceGraphiqueJeuDeLaVie(unSimulateur, longueur));
            unSimulateur.Play();
            return unSimulateur;
        }
    }
}