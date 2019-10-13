using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReSeller : AutomobileAudiBase
{
}

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base Info:");
            ReSeller ReSell = new ReSeller();
            ReSell.Info();
            Console.WriteLine();
            Console.WriteLine("ReSell Info:");
            ReSell.GetVIN("3333 - 3333 - 3333 - 3333");
            ReSell.Color = "Yellow";
            ReSell.Info();
            Console.ReadKey();
        }
    }
}
