using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKMPtor.xml.model.immeuble;

namespace CKMPtor.model
{
    class Immeuble
    {
        public Escaliers Escaliers { get; set; }
        public Etages Etages { get; set; }
        public Personnes Personnes { get; set; }
    }
}
