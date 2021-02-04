
//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Spieler.cs
//Datum:        04.02.2021
//Beschreibung:
//Aenderungen:  04.02.2021 Setup

namespace Teilnehmer
{
    public class Spieler : Teilnehmer
    {
        #region Attributes

        private double _speed;

        #endregion

        #region Properties

        public double Speed
        {
            get => _speed;
            set => _speed = value;
        }

        #endregion

        #region Constructors

        public Spieler()
        {
        }

        public Spieler(string name) : base(name)
        {
        }

        public Spieler(string name, double speed) : base(name)
        {
            this.Speed = speed;
        }

        #endregion

        #region Methods

        public double GiveSpeed()
        {
            return this.Speed;
        }

        #endregion
    }
}