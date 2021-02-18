

//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Physio.cs
//Datum:        18.02.2021
//Beschreibung: Physio class
//Aenderungen:  08.02.2021 Setup

using System;

namespace Teilnehmer.Model
{
    public class Physio : Teilnehmer
    {
        #region Attributes

        private int _experience;


        #endregion

        #region Properties

        public int Experience
        {
            get => _experience;
            set => _experience = value;
        }

        #endregion

        #region Constructors

        public Physio()
        {
            this.Experience = 0;
        }

        public Physio(string name) : base(name)
        {
             this.Experience = 0;

        }

        public Physio(string name, int experience) : base(name)
        {
            this.Experience = experience;
        }

        #endregion

        #region Methods

        public int HowExperienced()
        {
            return this.Experience;
        }

        public override string GiveInfo()
        {
            return base.GiveInfo() + ", " + $"Experience: {Experience}";
        }

        #endregion
    }
}