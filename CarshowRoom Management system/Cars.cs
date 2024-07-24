using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarshowRoom_Management_system
{

    
      class Cars : Showroom,Utility
    {
        private string carName;
        private string carColor;
        private string carFuelType;
        private int carPrice;
        private string carType;
        private string carTransmission;
        private static int totalCarsInStock = 0;

        public void get_details()
        {
            Console.WriteLine("NAME: " + carName);
            Console.WriteLine("COLOR: " + carColor);
            Console.WriteLine("FUEL TYPE: " + carFuelType);
            Console.WriteLine("PRICE: " + carPrice);
            Console.WriteLine("CAR TYPE: " + carType);
            Console.WriteLine("TRANSMISSION: " + carTransmission);
        }

        public void set_details()
        {
            Console.WriteLine("======================= *** ENTER CAR DETAILS *** =======================");
            Console.WriteLine();
            Console.Write("CAR NAME: ");
            carName = Console.ReadLine();
            Console.Write("CAR COLOR: ");
            carColor = Console.ReadLine();
            Console.Write("CAR FUEL TYPE(PETROL/DIESEL): ");
            carFuelType = Console.ReadLine();
            Console.Write("CAR PRICE: ");
            carPrice = int.Parse(Console.ReadLine());
            Console.Write("CAR TYPE(SEDAN/SUV/HATCHBACK): ");
            carType = Console.ReadLine();
            Console.Write("TRANSMISSION TYPE(AUTOMATIC/MANUAL): ");
            carTransmission = Console.ReadLine();
            total_car_in_stock++;
        }
    }
 }
