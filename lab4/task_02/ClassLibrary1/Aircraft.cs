using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Aircraft : IAircraft
    {
        public string Identifier { get; }
        private readonly ICommandCentre _commandCentre;

        public Aircraft(string identifier, ICommandCentre commandCentre)
        {
            Identifier = identifier;
            _commandCentre = commandCentre;
        }

        public void RequestTakeOff()
        {
            Console.WriteLine($"{Identifier} requesting takeoff.");
            _commandCentre.HandleTakeOffRequest(this);
        }

        public void RequestLanding()
        {
            Console.WriteLine($"{Identifier} requesting landing.");
            _commandCentre.HandleLandingRequest(this);
        }

        public void ReceiveClearance(string message)
        {
            Console.WriteLine($"{Identifier} received clearance: {message}");
        }
    }

}
