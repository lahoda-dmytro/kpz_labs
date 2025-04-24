using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ICommandCentre
    {
        void RegisterAircraft(IAircraft aircraft);
        void RegisterRunway(IRunway runway);
        void HandleTakeOffRequest(IAircraft aircraft);
        void HandleLandingRequest(IAircraft aircraft);
    }
}
