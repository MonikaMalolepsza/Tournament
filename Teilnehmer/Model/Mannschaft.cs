
//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Mannschaft.cs
//Datum:        04.02.2021
//Beschreibung:
//Aenderungen:  04.02.2021 Setup

using System.Collections.Generic;

namespace Teilnehmer.Model
{
    public class Mannschaft : Teilnehmer
    {
        #region Attributes

        private List<Teilnehmer> _team;


        #endregion

        #region Properties

        public List<Teilnehmer> Team
        {
            get => _team;
            set => _team = value;
        }

        #endregion

        #region Constructors

        public Mannschaft()
        {
            Team = new List<Teilnehmer>();
        }

        public Mannschaft(string name) : base(name)
        {
            Team = new List<Teilnehmer>();
        }

        public Mannschaft(string name, List<Teilnehmer> team) : base(name)
        {
            Team = team;
        }

        #endregion

        #region Methods

        public void NeueMietglied(Teilnehmer teilnehmer)
        {
            Team.Add(teilnehmer);
        }

        public string AusgabeMannschaftsInformationen()
        {
            string res = $"Mannschaft: {Name}\r\n";
            foreach (Teilnehmer t in Team)
            {
                res += t.GiveInfo();
            }
            return res;
        }
        #endregion
    }
}