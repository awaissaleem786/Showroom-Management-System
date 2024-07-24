using System;

namespace CarshowRoom_Management_system
{
     class Employees : Showroom, Utility
    {
        private string empId;
        private string empName;
        private int empAge;
        private string empDepartment;

        public void GetDetails()
        {
            Console.WriteLine("ID: " + empId);
            Console.WriteLine("Name: " + empName);
            Console.WriteLine("Age: " + empAge);
            Console.WriteLine("Department: " + empDepartment);
            Console.WriteLine("Showroom Name: " + showroom_name); 
        }

        public void SetDetails()
        {
            empId = Guid.NewGuid().ToString();
            Console.WriteLine("======================= *** ENTER EMPLOYEE DETAILS *** =======================");
            Console.WriteLine();
            Console.Write("EMPLOYEE NAME: ");
            empName = Console.ReadLine();
            Console.Write("EMPLOYEE AGE: ");
            empAge = int.Parse(Console.ReadLine());
            Console.Write("EMPLOYEE DEPARTMENT: ");
            empDepartment = Console.ReadLine();
            Console.Write("SHOWROOM NAME: ");
            showroom_name = Console.ReadLine(); 
        }
    }
}
