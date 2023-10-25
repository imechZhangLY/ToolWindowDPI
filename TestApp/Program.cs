using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var implementingClass = new ImplementingLibrary.ImplementingClass();
            Console.WriteLine(implementingClass.GetText());
            Console.ReadLine();
        }
    }
}
