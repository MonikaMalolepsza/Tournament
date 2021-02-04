
//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Teilnehmer.cs
//Datum:        04.02.2021
//Beschreibung:
//Aenderungen:  04.02.2021 Setup


namespace Teilnehmer
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
                }

                public Teilnehmer(string name)
                {
                    Name = name;
                }

        #endregion

        #region Methods

        public string GiveName()
        {
            return this.Name;
        }

        #endregion
    }
}
