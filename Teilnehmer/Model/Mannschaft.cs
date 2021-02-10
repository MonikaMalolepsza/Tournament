
//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Mannschaft.cs
//Datum:        04.02.2021
//Beschreibung:
//Aenderungen:  04.02.2021 Setup

using System.Collections.Generic;

namespace Teilnehmer
{
    public class Mannschaft : Teilnehmer
    {
        #region Attributes

        private List<Spieler> _team;
        private Trainer _trainer;


        #endregion

        #region Properties

        public List<Spieler> Team
        {
            get => _team;
            set => _team = value;
        }
        public Trainer Trainer
        {
            get => _trainer;
            set => _trainer = value;
        }

        #endregion

        #region Constructors

        public Mannschaft(string name, Trainer t) : base(name)
        {
            Team = new List<Spieler>();
            Trainer = t;
        }
        

        #endregion

        #region Methods

        public void NeueMietglied(Spieler spieler)
        {
            Team.Add(spieler);
        }

        public string AusgabeMannschaftsInformationen()
        {
            string res = $"Mannschaft: {Name}\r\n";
            foreach (Spieler s in Team)
            {
                res += $"Name: {s.Name}\r\nSpeed: {s.Speed}\r\nSpielt gerade?: {(s.Active ? "Ja" : "Nein")}";
            }
            return res;
        }
        #endregion
    }
}