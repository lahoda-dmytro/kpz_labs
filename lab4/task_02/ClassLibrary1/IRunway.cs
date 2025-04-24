using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IRunway
    {
        string Name { get; }
        bool IsAvailable { get; }
        void Occupy();
        void Vacate();
    }
}
