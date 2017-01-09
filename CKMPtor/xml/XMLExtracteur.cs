using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CKMPtor.xml.model;
using CKMPtor.xml.model.fourmiliere;

namespace CKMPtor
{
    class XMLExtracteur
    {
        public String Chemin { get; set; }

        public XMLExtracteur(string chemin)
        {
            Chemin = chemin;
        }

        public DonnéesSimulateur Lancer()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Chemin);

            from element in xml
            select new DonnéesSimulateur
            {
               Fourmiliere = (
               from valeur in element.Elements("fourmiliere")
                select new Fourmis { Nombre = (int)valeur.Elements("nombre")})
            };


            return null;
        }

    }
}
