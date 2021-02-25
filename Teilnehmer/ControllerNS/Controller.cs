using Teilnehmer.Model;
using Teilnehmer.View;

namespace Teilnehmer.ControllerNS
{
    public class Controller
    {

        #region Attributes

        private Mannschaft _mannschaft;
        private Spieler _spieler;
        private Schiedsrichter _schiedsrichter;
        private Trainer _trainer;
        private Physio _physio;
        private UserInterface _userInterface;

        #endregion

        #region Properties

        public Physio Physio
        {
            get => _physio;
            set => _physio = value;
        }

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

        public UserInterface UserInterface
        {
            get => _userInterface;
            set => _userInterface = value;
        }

        #endregion

        #region Constructors

        public Controller()
        {
            Mannschaft = new Mannschaft();
            Spieler = new Spieler();
            Physio = new Physio();
            Trainer = new Trainer();
            Schiedsrichter = new Schiedsrichter();
            UserInterface = new UserInterface();
        }

        public Controller( Mannschaft team, Trainer trainer, Schiedsrichter schiedsrichter, UserInterface ui, Spieler spieler, Physio physio)
        {
            Mannschaft = team;
            Spieler = spieler;
            Physio = physio;
            Trainer = trainer;
            Schiedsrichter = schiedsrichter;
            UserInterface = ui;
        }

        #endregion

        #region Methods

        public void  Test()
        {
            Spieler  s = new Spieler("Jens", 70.5, true);
            Trainer t = new Trainer("Thomas", 50);
            Physio p = new Physio("Monika", 2);
            Mannschaft m = new Mannschaft("FC Koeln");
            UserInterface ui = new UserInterface();
            m.NeueMietglied(s);
            m.NeueMietglied(t);
            m.NeueMietglied(p);
            ui.WriteText(m.AusgabeMannschaftsInformationen());
            ui.ReadText();
        }



        #endregion
    }
}