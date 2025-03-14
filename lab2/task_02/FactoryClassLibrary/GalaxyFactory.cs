using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryClassLibrary
{
    public class GalaxyFactory: Factory
    {
        public Laptop CreateLaptop() => new GalaxyLaptop();
        public Smartphone CreateSmartphone() => new GalaxyPhone();
    }
}
