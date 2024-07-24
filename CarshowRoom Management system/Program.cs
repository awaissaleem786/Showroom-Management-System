

using CarshowRoom_Management_system;
interface Utility
{
    public void get_details();
    public void set_details();
}



class MainClass
{

    static void main_menu()
    {
        Console.WriteLine();
        Console.WriteLine("======================= *** WELCOME TO SHOWROOM MANAGEMENT SYSTEM *** =======================");
        Console.WriteLine();
        Console.WriteLine("=============================== *** ENTER YOUR CHOICE *** ===============================");
        Console.WriteLine();
        Console.WriteLine("1]. ADD SHOWROOMS \t\t\t 2].GET SHOWROOMS \t\t\t 3].ADD EMPLOYEES"); 
        Console.WriteLine();
        Console.WriteLine("4]. GET EMPLOYEES \t\t\t 5].ADD CARS      \t\t\t 6].GET CARS");
        Console.WriteLine();
        Console.WriteLine("=============================== *** ENTER 0 TO EXIT *** ===============================");
    }
    public static void Main(string[] args)
    {
        
        LinkedList<Showroom> showrooms=new LinkedList<Showroom>();
        Employees[] empolyees = new Employees[5];  // Employee class ka object jo ha wo array type ka ha 
        Cars[] cars = new Cars[5];
        int indexshowroom = 0;
        int indexempoly = 0;
        int indexcar=0;
        int choice = -1;
        while(choice!=0)
        {
            main_menu();
            Console.WriteLine(" Enter your Choice: ");
            choice = int.Parse(Console.ReadLine());
            while (choice != 9 && choice != 0)
            {
                switch (choice)
                {
                    case 1:
                         Showroom showroom = new Showroom();
                             showroom.set_details();
                              showrooms.AddLast(showroom);
                        Console.WriteLine("1].ADD NEW SHOWROOM");
                        Console.WriteLine("9].GO BACK TO MAIN MENU");
                        choice = int.Parse(Console.ReadLine());
                        break;

                        case 2:

                        foreach(var item in showroom)
                        {
                            item.get_details();
                        }

                        for (int i = 0; i < indexshowroom; i++)
                        {
                            showroom[i].get_details();
                        }
                        Console.WriteLine("9].Go Back TO MAIN MENU");
                        Console.WriteLine("0].EXIT");
                        choice = int.Parse(Console.ReadLine());
                        break;
                        case 3:
                            empolyees[indexempoly] = new Employees();
                            empolyees[indexempoly].set_details();
                            indexempoly++;
                            Console.WriteLine("3].ADD EMPLOYEES");
                            Console.WriteLine("9].Go Back TO MAIN MENU");
                           choice = int.Parse(Console.ReadLine());
                        break;
                        case 4:
                            for(int i=0; i<indexempoly; i++)
                            {
                            empolyees[i].get_details();
                            }
                        Console.WriteLine("9[.Go Back TO MAIN MENU");
                        Console.WriteLine("0].EXIT");
                        choice = int.Parse(Console.ReadLine());
                        break;
                        case 5:
                        cars[indexcar] = new Cars();
                        cars[indexcar].set_details();
                        indexcar++;
                        Console.WriteLine("5].ADD CARS");
                        Console.WriteLine("9[.Go Back TO MAIN MENU");
                        choice= int.Parse(Console.ReadLine());
                        break;
                         case 6:
                         for(int i=0;i<indexcar;i++)
                        {
                            cars[i].get_details();
                        }

                        Console.WriteLine("9].Go Back TO MAIN MENU");
                        Console.WriteLine("0].EXIT");
                        choice = int.Parse(Console.ReadLine());
                        break;
                        case 0:
                        return;
                      default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;

                }
            }
        }
    }

}
