namespace CKMPtor
{
    public abstract class InterfaceGraphique
    {
        protected Simulateur simulation { get; }

        public Commande CommandePlay { get; }
        public Commande CommandePause { get; }
        public Commande CommandeRetour { get; }

        protected InterfaceGraphique(Simulateur uneSimulation)
        {
            CommandePlay = new Commande(play);
            CommandePause = new Commande(pause);
            CommandeRetour = new Commande(retour);

            simulation = uneSimulation;
        }

        private void play()
        {
            simulation.Play();
        }

        private void pause()
        {
            simulation.Pause();
        }

        private void retour()
        {
            simulation.Retour();
        }

        public abstract void Refresh();
    }
}