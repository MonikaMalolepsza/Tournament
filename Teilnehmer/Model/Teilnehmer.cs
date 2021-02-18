
//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Teilnehmer.cs
//Datum:        04.02.2021
//Beschreibung:
//Aenderungen:  04.02.2021 Setup


using System;

namespace Teilnehmer.Model
{
    public class Teilnehmer
    {
        #region Attributes

        private string _name;

        #endregion

        #region Properties


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        #endregion

        #region Constructors

                public Teilnehmer()
                {
                    Name = "";
                }

                public Teilnehmer(string name)
                {
                    Name = name;
                }

        #endregion

        #region Methods

        public virtual string GiveInfo()
        {
            return this.Name;
          // Console.WriteLine(this.Name);
        }

        #endregion
    }
}
