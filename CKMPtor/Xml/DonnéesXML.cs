using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKMPtor.Xml
{
    class DonnéesXML
    {

        private DonnéesInitialeSimulateurs simulateurs;
        private static DonnéesXML INSTANCE;

        private DonnéesXML()
        {
            XMLExtracteur extracteur = new XMLExtracteur("../../Xml/DonnéesInitial.xml");
            this.simulateurs = extracteur.Lancer();
        }

        public static DonnéesInitialeSimulateurs Réccupérer()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new DonnéesXML();
            }

            return INSTANCE.simulateurs;
        }
    }
}
