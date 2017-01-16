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

            DonnéesInitialeSimulateurs donnéesXML = DonnéesXML.Réccupérer();

            Random rand = new Random();

            int longueur = donnéesXML.Fourmiliere.Carte.Longeur;
            int largeur = donnéesXML.Fourmiliere.Carte.Largeur;
            int i;

            Parcelle[,] parcelles = new Parcelle[longueur, largeur];

            for (i = 0; i < longueur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    parcelles[i, j] = new Parcelle(unSimulateur);
                    unSimulateur.AjouterZone(parcelles[i, j]);

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

            Parcelle uneParcelleDeDépart = (unSimulateur.Zones[rand.Next(0, unSimulateur.Zones.Count)] as Parcelle);
            uneParcelleDeDépart.AjouterObjet(new Fourmiliere(unSimulateur, uneParcelleDeDépart));
            
            for (i = 0; i < donnéesXML.Fourmiliere.Fourmis.Nombre; i++)
            {
                unSimulateur.AjouterPersonnage(new Fourmi(donnéesXML.Fourmiliere.Pheromones.Poids));
            }

            i = 0;
            while (i < donnéesXML.Fourmiliere.Objectif.Nombre)
            {
                Parcelle uneParcelle = (unSimulateur.Zones[rand.Next(0, unSimulateur.Zones.Count)] as Parcelle);

                if (uneParcelle.estVide())
                {
                    uneParcelle.AjouterObjet(new Objectif(donnéesXML.Fourmiliere.Pheromones.Poids));
                    i++;
                }
            }

            unSimulateur.Interfaces.Add(new InterfaceGraphiqueFourmiliere(unSimulateur, largeur));
            unSimulateur.Play();

            return unSimulateur;
        }
    }
}
