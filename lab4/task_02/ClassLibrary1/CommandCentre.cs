using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CommandCentre : ICommandCentre
    {
        private readonly List<IAircraft> _aircrafts = new List<IAircraft>();
        private readonly List<IRunway> _runways = new List<IRunway>();

        public void RegisterAircraft(IAircraft aircraft)
        {
            _aircrafts.Add(aircraft);
            Console.WriteLine($"Aircraft {aircraft.Identifier} registered.");
        }

        public void RegisterRunway(IRunway runway)
        {
            _runways.Add(runway);
            Console.WriteLine($"Runway {runway.Name} registered.");
        }

        public void HandleTakeOffRequest(IAircraft aircraft)
        {
            var availableRunway = _runways.FirstOrDefault(r => r.IsAvailable);
            if (availableRunway != null)
            {
                availableRunway.Occupy();
                aircraft.ReceiveClearance($"Takeoff from {availableRunway.Name} granted.");
                availableRunway.Vacate();
            }
            else
            {
                aircraft.ReceiveClearance("No runways available for takeoff.");
            }
        }

        public void HandleLandingRequest(IAircraft aircraft)
        {
            var availableRunway = _runways.FirstOrDefault(r => r.IsAvailable);
            if (availableRunway != null)
            {
                availableRunway.Occupy();
                aircraft.ReceiveClearance($"Landing on {availableRunway.Name} granted.");
                availableRunway.Vacate();
            }
            else
            {
                aircraft.ReceiveClearance("No runways available for landing.");
            }
        }
    }

}
