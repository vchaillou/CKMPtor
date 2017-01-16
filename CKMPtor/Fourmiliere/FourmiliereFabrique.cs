using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKMPtor.Xml;

namespace CKMPtor
{
    class FourmiliereFabrique : FabriqueAbstraite
    {
        public string Nom { get { return "Fourmilière"; } }

        public Simulateur CréerSimulateur()
        {
            Simulateur unSimulateur = new Simulateur();

            /*DonnéesInitialeSimulateurs donnéesXML = DonnéesXML.Réccupérer();

            Random rand = new Random();

            int longueur = donnéesXML.Fourmiliere.Carte.Longeur;
            int largeur = donnéesXML.Fourmiliere.Carte.Largeur;
            int i;

            Parcelle[,] parcelles = new Parcelle[longueur, largeur];

            for (i = 0; i < longueur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    unSimulateur.AjouterZone(parcelles[i, j]);
                    unSimulateur.AjouterPersonnage(parcelles[i, j].Occupant);

                    if (i > 0)
                    {
                        unSimulateur.AjouterAccès(new Tunnel(parcelles[i, j], parcelles[i - 1, j]));
                    }

                    if (j > 0)
                    {
                        unSimulateur.AjouterAccès(new Tunnel(parcelles[i, j], parcelles[i, j - 1]));
                    }
                }
            }

            (unSimulateur.Zones[rand.Next(0, unSimulateur.Zones.Count)] as Parcelle).AjouterObjet(new Fourmiliere(donnéesXML.Fourmiliere.Fourmis.Nombre));

            i = 0;
            while (i < donnéesXML.Fourmiliere.Objectif.Nombre)
            {
                Parcelle uneParcelle = (unSimulateur.Zones[rand.Next(0, unSimulateur.Zones.Count)] as Parcelle);

                if (uneParcelle.estVide())
                {
                    uneParcelle.AjouterObjet(new Pheromone(donnéesXML.Fourmiliere.Pheromones.Poids));
                    i++;
                }
            }

            unSimulateur.Interfaces.Add(new FourmiliereInterfaceGraphique(unSimulateur, longueur));
            unSimulateur.Play();*/

            return unSimulateur;
        }
    }
}
