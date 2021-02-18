using System;
using System.Net.Mime;

namespace Teilnehmer.View
{
    public class UserInterface
    {
        #region Attributes

        private string _text;

        #endregion

        #region Properties
        public string Text
        {
            get => _text;
            set => _text = value;
        }
        #endregion

        #region Constructors

        public UserInterface()
        {
            this.Text = "";
        }

        public UserInterface(string text)
        {
            this.Text = text;
        }

        #endregion

        #region Methods

        public void ReadText()
        {
            Console.WriteLine(Text);
        }
        public void WriteText(string text)
        {
            Text = text;
        }

        #endregion
    }
}