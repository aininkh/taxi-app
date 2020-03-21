using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp
{
    class Program
    {
        static void Main(string[] args)
        {
			// Membuat objek Taxi
            Taxi taxi = new Taxi();

            // Pengesetan nilai properties
            taxi.DriverName = "Aini";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // Pemanggilan method
            taxi.TaxiInfo();
			
			if (taxi.OnDuty == true)
			{
				//Taxi sedang mengantar penumpang
				taxi.PickUpPassenger();
				taxi.DropOffPassenger();
			}
			else if(taxi.OnDuty == false)
			{
				//Taxi sedang tidak mengantar penumpang
				Console.WriteLine("Taxi tersedia");
			}

            Console.ReadKey();
        }
    }
}