using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryClassLibrary
{
    public class XiaomiFactory: Factory
    {
        public Laptop CreateLaptop() => new XiaomiLaptop();
        public Smartphone CreateSmartphone() => new XiaomiPhone();
    }
}
