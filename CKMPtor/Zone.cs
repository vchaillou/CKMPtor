using System.Collections.Generic;

namespace CKMPtor
{
    public abstract class Zone
    {
        public HashSet<Accès> Chemins { get; }
        public Personnage Occupant { get; set; }

        protected Zone()
        {
            Chemins = new HashSet<Accès>();
        }
    }
}