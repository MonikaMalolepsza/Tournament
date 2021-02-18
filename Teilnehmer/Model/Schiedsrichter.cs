
//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Schiedsrichter.cs
//Datum:        04.02.2021
//Beschreibung:
//Aenderungen:  04.02.2021 Setup

using System;

namespace Teilnehmer.Model
{
    public class Schiedsrichter : Teilnehmer
    {
        #region Attributes

        /**
            Assistant Referee. (minimum age 12) ...
            Regional Referee. (minimum age 12) ...
            Intermediate Referee. (minimum age 14) ...
            Advanced Referee. (minimum age 16) ...
            National Referee. (minimum age 18)
         */
        private string _certificate;

        #endregion

        #region Properties


        public string Certificate
        {
            get => _certificate;
            set => _certificate = value;
        }

        #endregion

        #region Constructors

        public Schiedsrichter()
        {
            this.Certificate = "";
        }

        public Schiedsrichter(string name) : base(name)
        {
            this.Certificate = "";
        }

        public Schiedsrichter(string name, string certificate) : base(name)
        {
            this.Certificate = certificate;
        }

        #endregion

        #region Methods

        public string GiveCert()
        {
            return this.Certificate;
        }

        public override string GiveInfo()
        {
            return base.GiveInfo() + ", " + $"Certificate: {Certificate}";
        }

        #endregion
    }
}