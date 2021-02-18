
//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Spieler.cs
//Datum:        04.02.2021
//Beschreibung:
//Aenderungen:  04.02.2021 Setup

using System;

namespace Teilnehmer.Model
{
    public class Spieler : Teilnehmer
    {
        #region Attributes

        private double _speed;
        private bool _active;


        #endregion

        #region Properties

        public double Speed
        {
            get => _speed;
            set => _speed = value;
        }
        public bool Active
        {
            get => _active;
            set => _active = value;
        }

        #endregion

        #region Constructors

        public Spieler()
        {
            this.Speed = 0;
        }

        public Spieler(string name) : base(name)
        {
            this.Speed = 0;
        }

        public Spieler(string name, double speed, bool active) : base(name)
        {
            this.Speed = speed;
            this.Active = active;
        }

        #endregion

        #region Methods

        public bool IsActive()
        {
            return this.Active;
        }

        public void SwitchActive()
        {
            this.Active = !this.Active;
        }

        public override string GiveInfo()
        {
            return base.GiveInfo() + ", " + $"Speed: {Speed}" + ", " + $"{(Active ? "Ja" : "Nein")}";
        }

        #endregion
    }
}