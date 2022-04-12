using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTaxi
{
    internal class Taxi
    {
        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public string NumPassager { get; set; }

        public void PickUpPassager()
        {
            Console.WriteLine("Driver Name        : {0}", DriverName);
            Console.WriteLine("On Duty            : {0}", OnDuty);
            Console.WriteLine("Number of Passager : {0}", NumPassager);
            Console.WriteLine("\nSedang Menjemput Penumpang");

        }
        public void DropOffPassager()
        {
            Console.WriteLine("Selesai Mengantar Penumpang",DriverName);
        }
    }
}
