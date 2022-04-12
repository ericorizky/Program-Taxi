using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTaxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName  = "Erico";
            taxi.OnDuty      = "YES";
            taxi.NumPassager = "20";

            taxi.PickUpPassager();
            taxi.DropOffPassager();

            Console.ReadKey();
        }
    }
}
