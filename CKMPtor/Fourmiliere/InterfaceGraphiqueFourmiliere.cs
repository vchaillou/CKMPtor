using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CKMPtor.Xml;

namespace CKMPtor
{
    class InterfaceGraphiqueFourmiliere : InterfaceGraphique
    {
        private readonly int longueurLigne;
        private Window fenetre = new Window();
        private Grid grilleDynamique = new Grid();


        public InterfaceGraphiqueFourmiliere(Simulateur unSimulateur, int uneLongueurLigne) : base(unSimulateur)
        {
            longueurLigne = uneLongueurLigne;
            Application.Current.Dispatcher.Invoke(CreationDeLaFenetre);
            fenetre.Show();

        }

        public override void Refresh()
        {
            Application.Current.Dispatcher.Invoke(() => {

                IEnumerator<TextBlock> iterateurTextblock = grilleDynamique.Children.OfType<TextBlock>().GetEnumerator();

                foreach (Parcelle uneCase in simulation.Zones.Cast<Parcelle>())
                {
                    iterateurTextblock.MoveNext();
                    Objet objet = uneCase.PrendreObjet();

                    string marque = " ";
                    if (objet is Pheromone)
                    {
                        marque = "-";
                    }

                    if (uneCase.Occupant != null)
                    {
                        EtatFourmi etatCellule = (uneCase.Occupant as Fourmi).Etat;
                        if (etatCellule == EtatDehors.GetInstance)
                        {
                            marque = "∞";
                        }
                    }

                    if (objet is Fourmiliere)
                    {
                        marque = "ʍ";
                    }
                    if (objet is Objectif)
                    {
                        marque = "O";
                    }

                    TextBlock textblock = iterateurTextblock.Current;
                    textblock.Text = marque;
                    Console.Write(marque);

                    if (Grid.GetColumn(textblock) == longueurLigne - 1)
                    {
                        Console.WriteLine("");
                    }
                }
            });
        }

        private void CreationDeLaFenetre()
        {
            if (fenetre == null)
                throw new Exception("Aucune fenêtre instancié.");

            var DonnéesXml = DonnéesXML.Réccupérer();

            grilleDynamique.HorizontalAlignment = HorizontalAlignment.Stretch;
            grilleDynamique.VerticalAlignment = VerticalAlignment.Stretch;
            grilleDynamique.ShowGridLines = true;
            grilleDynamique.Background = new SolidColorBrush(Color.FromArgb(255, 240, 203, 128));

            for (int i = 0; i < DonnéesXml.Fourmiliere.Carte.Largeur; i++)
            {
                grilleDynamique.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < DonnéesXml.Fourmiliere.Carte.Longeur; i++)
            {
                grilleDynamique.RowDefinitions.Add(new RowDefinition());
            }

            // Initialisation grille
            int ligne = 0;
            int colonne = 0;

            foreach (Parcelle uneCase in simulation.Zones.Cast<Parcelle>())
            {
                TextBlock bookText = new TextBlock();
                bookText.FontSize = 40;
                bookText.FontWeight = FontWeights.Bold;
                Grid.SetRow(bookText, ligne);
                Grid.SetColumn(bookText, colonne);
                bookText.HorizontalAlignment = HorizontalAlignment.Center;
                bookText.VerticalAlignment = VerticalAlignment.Center;
                grilleDynamique.Children.Add(bookText);

                colonne++;
                if (colonne >= longueurLigne)
                {
                    colonne = 0;
                    ligne++;
                }
            }

            Refresh();

            fenetre.Content = grilleDynamique;
        }
    }
}
