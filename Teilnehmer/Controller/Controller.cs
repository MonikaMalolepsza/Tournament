namespace Teilnehmer.Controller
{
    public class Controller
    {

        #region Attributes

        private Mannschaft _mannschaft;
        private Spieler _spieler;
        private Schiedsrichter _schiedsrichter;
        private Trainer _trainer;


        #endregion

        #region Properties

        public Trainer Trainer
        {
            get => _trainer;
            set => _trainer = value;
        }

        public Mannschaft Mannschaft
        {
            get => _mannschaft;
            set => _mannschaft = value;
        }

        public Spieler Spieler
        {
            get => _spieler;
            set => _spieler = value;
        }

        public Schiedsrichter Schiedsrichter
        {
            get => _schiedsrichter;
            set => _schiedsrichter = value;
        }

        #endregion

        #region Constructors

        public Controller()
        {
        }

        public Controller( Mannschaft team, Trainer trainer, Schiedsrichter schiedsrichter)
        {
            Mannschaft = team;
            Trainer = trainer;
            Schiedsrichter = schiedsrichter;
        }

        #endregion

        #region Methods

        public void  Test()
        {
            Spieler  s = new Spieler("Jens", 70.5, true);
            Trainer t = new Trainer("Thomas", 50);
            Mannschaft m = new Mannschaft("FC Koeln", t);
            m.NeueMietglied(s);
        }

        #endregion
    }
}