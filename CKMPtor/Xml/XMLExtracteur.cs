using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CKMPtor.Xml
{
    class XMLExtracteur
    {
        public String Chemin { get; set; }

        public XMLExtracteur(string chemin)
        {
            Chemin = chemin;
        }

        public DonnéesInitialeSimulateurs Lancer()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DonnéesInitialeSimulateurs));
            using (StreamReader reader = new StreamReader(Chemin))
            {
                DonnéesInitialeSimulateurs result = (DonnéesInitialeSimulateurs)serializer.Deserialize(reader);
                return result;
            }
        }
    }
}
