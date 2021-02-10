

//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Spieler.cs
//Datum:        04.02.2021
//Beschreibung:
//Aenderungen:  04.02.2021 Setup

namespace Teilnehmer
{
    public class Trainer : Teilnehmer
    {
        #region Attributes

        private int _age;


        #endregion

        #region Properties

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        #endregion

        #region Constructors

        public Trainer()
        {
        }

        public Trainer(string name) : base(name)
        {
        }

        public Trainer(string name, int age) : base(name)
        {
            this.Age = age;
        }

        #endregion

        #region Methods

        public int HowOld()
        {
            return this.Age;
        }

        #endregion
    }
}