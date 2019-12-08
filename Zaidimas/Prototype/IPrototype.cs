using System;
using System.Collections.Generic;
using System.Text;

namespace Zaidimas.Prototype
{
        public interface IPrototype
        {
            IPrototype Clone();
            String GetDetails();
        }
}
