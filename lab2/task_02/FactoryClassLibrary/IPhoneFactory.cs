using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryClassLibrary
{
    public class IPhoneFactory : Factory
    {
        public Laptop CreateLaptop() => new IPhoneLaptop();
        public Smartphone CreateSmartphone() => new IPhonePhone();
    }
    
}
