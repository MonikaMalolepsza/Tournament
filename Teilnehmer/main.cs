using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teilnehmer.Controller;

namespace Teilnehmer
{
    class main
    {
        static void Main(string[] args)
        {
            Controller.Controller controller = new Controller.Controller();
            controller.Test();
        }
    }
}