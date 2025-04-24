using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICommandCentre commandCentre = new CommandCentre();

            IRunway runway1 = new Runway("Runway A");
            IRunway runway2 = new Runway("Runway B");

            commandCentre.RegisterRunway(runway1);
            commandCentre.RegisterRunway(runway2);

            IAircraft aircraft1 = new Aircraft("Flight 101", commandCentre);
            IAircraft aircraft2 = new Aircraft("Flight 202", commandCentre);

            commandCentre.RegisterAircraft(aircraft1);
            commandCentre.RegisterAircraft(aircraft2);

            aircraft1.RequestTakeOff();
            aircraft2.RequestLanding();
        }
    }
}
