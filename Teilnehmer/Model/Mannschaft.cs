
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
        
        #endregion

        #region Properties

        public List<Spieler> Team
        {
            get => _team;
            set => _team = value;
        }

        #endregion

        #region Constructors

        public Mannschaft()
        {
            Team = new List<Spieler>();
        }

        public Mannschaft(string name, List<Spieler> list) : base(name)
        {
            this.Team = list;
        }

        #endregion

        #region Methods
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