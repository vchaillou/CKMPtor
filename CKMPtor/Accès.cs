namespace CKMPtor
{
    public abstract class Accès
    {
        private Zone _début;
        private Zone _fin;

        public Zone Début
        {
            get { return _début; }
            set
            {
                _début = value;
                Début.Chemins.Add(this);
            }
        }

        public Zone Fin
        {
            get { return _fin; }
            set
            {
                _fin = value;
                Fin.Chemins.Add(this);
            }
        }

        public Zone autreBout(Zone uneZone)
        {
            return uneZone == Début ? Fin : Début;
        }

        protected Accès(Zone unDébut, Zone uneFin)
        {
            Début = unDébut;
            Fin = uneFin;
        }
    }
}