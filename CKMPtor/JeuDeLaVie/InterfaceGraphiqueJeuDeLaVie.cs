using System;
using System.Linq;
using System.Security.Principal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CKMPtor.Xml;

namespace CKMPtor
{
    internal class InterfaceGraphiqueJeuDeLaVie : InterfaceGraphique
    {
        private readonly int longueurLigne;
        private Window fenetre = new Window();
        private Grid grilleDynamique = new Grid();


        public InterfaceGraphiqueJeuDeLaVie(Simulateur unSimulateur, int uneLongueurLigne) : base(unSimulateur)
        {
            longueurLigne = uneLongueurLigne;
            Application.Current.Dispatcher.Invoke(CreationDeLaFenetre);
            fenetre.Show();

        }

        public override void Refresh()
        {
            Application.Current.Dispatcher.Invoke(() => { 

                int ligne = 0;
                int colonne = 0;
               

                grilleDynamique.Children.Clear();
                grilleDynamique.UpdateLayout();

                foreach (Case uneCase in simulation.Zones.Cast<Case>())
                {
                    var etatCellule = (uneCase.Occupant as Cellule).État;

                    if (etatCellule == EtatCellule.VIVANTE)
                    {
                        TextBlock bookText = new TextBlock();
                        bookText.Text = "*";
                        Console.Write("*");
                        bookText.FontSize = 40;
                        bookText.FontWeight = FontWeights.Bold;
                        Grid.SetRow(bookText, ligne);
                        Grid.SetColumn(bookText, colonne);
                        grilleDynamique.Children.Add(bookText);
                        grilleDynamique.UpdateLayout();

                    }
                    else if(etatCellule == EtatCellule.MORTE)
                    {
                        TextBlock bookText = new TextBlock();
                        bookText.Text = " ";
                        Console.Write("");
                        bookText.FontSize = 40;
                        bookText.FontWeight = FontWeights.Bold;
                        Grid.SetRow(bookText, ligne);
                        Grid.SetColumn(bookText, colonne);
                        grilleDynamique.Children.Add(bookText);
                        grilleDynamique.UpdateLayout();

                    }
                    
                    if (colonne < longueurLigne)
                    {
                        colonne = 0;
                        ligne++;
                        Console.WriteLine("");
                    }
                    colonne++;

                }
                grilleDynamique.UpdateLayout();
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
            grilleDynamique.Background = new SolidColorBrush(Color.FromArgb(255,255,222,240));

            for (int i = 0; i < DonnéesXml.JeuDeLaVie.Carte.Largeur; i++)
            {
                grilleDynamique.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < DonnéesXml.JeuDeLaVie.Carte.Largeur; i++)
            {
                grilleDynamique.RowDefinitions.Add(new RowDefinition());
            }
            fenetre.Content = grilleDynamique;
        }
    }
}