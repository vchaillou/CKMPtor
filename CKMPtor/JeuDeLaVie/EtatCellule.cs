namespace CKMPtor
{
    public class EtatCellule
    {
        public static EtatCellule VIVANTE = new EtatVivante();
        public static EtatCellule MORTE = new EtatMorte();

        public StrategieCellule Strategie;
    }

    public class EtatVivante : EtatCellule
    {
        public EtatVivante()
        {
            Strategie = new StrategieMourir();
        }
    }

    public class EtatMorte : EtatCellule
    {
        public EtatMorte()
        {
            Strategie = new StrategieRevivre();
        }
    
    }
}