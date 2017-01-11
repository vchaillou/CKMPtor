using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CKMPtor.Xml
{
    public class XMLStructure
    {
        public DonnéesInitialeSimulateurs DonnéesInitialeSimulateurs { get; set; }
    }

    [XmlRoot("simulateurs")]
    public class DonnéesInitialeSimulateurs
    {
        [XmlElement("immeuble")]
        public Immeuble Immeuble { get; set; }

        [XmlElement("fourmiliere")]
        public Fourmiliere Fourmiliere { get; set; }

        [XmlElement("jeu-de-la-vie")]
        public JeuDeLaVie JeuDeLaVie { get; set; }
    }

    public class Immeuble
    {
        [XmlElement("escaliers")]
        public Escalier Escalier { get; set; }

        [XmlElement("personnes")]
        public Personne Personne { get; set; }

        [XmlElement("etages")]
        public Etage Etage { get; set; }
    }

    public class Fourmiliere
    {
        [XmlElement("fourmis")]
        public Fourmis Fourmis { get; set; }

        [XmlElement("objectif")]
        public Objectif Objectif { get; set; }

        [XmlElement("carte")]
        public Carte Carte { get; set; }

        [XmlElement("pheromones")]
        public Pheromones Pheromones { get; set; }
    }

    public class JeuDeLaVie
    {
        [XmlElement("carte")]
        public Carte Carte { get; set; }

        [XmlElement("cellules")]
        public Cellules Cellules { get; set; }
    }


    public class Escalier
    {
        [XmlElement("nombre")]
        public int Nombre { get; set; }
    }
    public class Personne
    {
        [XmlElement("nombre")]
        public int Nombre { get; set; }
    }
    public class Etage
    {
        [XmlElement("nombre")]
        public int Nombre { get; set; }

        [XmlElement("longeur")]
        public int Longeur { get; set; }
    }

    public class Fourmis
    {
        [XmlElement("nombre")]
        public int Nombre { get; set; }
    }
    public class Objectif
    {
        [XmlElement("nombre")]
        public int Nombre { get; set; }
    }
    public class Carte
    {
        [XmlElement("longeur")]
        public int Longeur { get; set; }

        [XmlElement("largeur")]
        public int Largeur { get; set; }
    }
    public class Pheromones
    {
        [XmlElement("poids")]
        public int Poids { get; set; }
    }

    public class Cellules
    {
        [XmlElement("vivante")]
        public int Vivante { get; set; }
    }

}
