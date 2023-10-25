using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingLibrary
{
    public class ImplementingClass : InterfaceLibrary.IClass1
    {
        public string GetText()
        {
            return "Hello World";
        }
    }
}
