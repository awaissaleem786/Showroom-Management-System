using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarshowRoom_Management_system
{
    class Showroom : Utility
    {
      protected  string showroom_name;
        string showroom_address;
        string manager_name;
        int total_empolyee;
      protected int total_car_in_stock=0;

        public void get_details()
        {
            Console.WriteLine(" Showroom Name: "+showroom_name);

            Console.WriteLine(" Showroom Address: " + showroom_address);

            Console.WriteLine(" Showroom Manager Name: " + manager_name);

            Console.WriteLine(" Total Empolyee: " + total_empolyee);

            Console.WriteLine(" Total Car in Stock: " + total_car_in_stock);
        }
        public void set_details() 
        {

            Console.WriteLine("======================= ***ENTER SHOWROOM DETAILS * ** ======================= ");
            Console.WriteLine(" Enter your Showroom NAME: ");
            showroom_name = Console.ReadLine();
            Console.WriteLine(" Enter your Address:");
            showroom_address = Console.ReadLine();
            Console.WriteLine(" Enter the Manager Name: ");
            manager_name = Console.ReadLine();
            Console.WriteLine(" Enter total Empolyee:");
            total_empolyee =int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter total_Cars in Stock:");
            total_car_in_stock = int.Parse(Console.ReadLine());
        }
    }
}
