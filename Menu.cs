using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public class Menu
    {
        public static void menuReturn(Restaurant r)
        {
            Console.WriteLine();
            Console.WriteLine("Return to the menu - 0");
            Console.WriteLine();

            int state_menu = 1;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out state_menu) && state_menu == 0)
            {
                Console.Clear();
                Menu.menu(r);
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Incorrect input, try again");
                Console.WriteLine();

                menuReturn(r);
            }
        }
        public static int menu(Restaurant r)
        {
            Console.WriteLine("Welcome to the restaurant \"{0}\"!", r.getName());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Menu");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Watch price list - 1");
            Console.WriteLine("Add new dish - 2");
            Console.WriteLine("Make a new order - 3");
            Console.WriteLine("Watch restaurant income - 4");
            Console.WriteLine("Leave restaurant - 5");
            Console.WriteLine();


            int state = 0;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out state) && state >= 1 && state <= 5)
            {
                Console.Clear();

                if (state == 1)
                {


                    Dish.priceList();

                    menuReturn(r);

                    return 1;

                }
                if (state == 2)
                {
                    Console.Clear();

                    Dish.menuCreate();
                    menuReturn(r);
                    return 1;
                }
                if (state == 3)
                {
                    Console.Clear();

                    Order.menuOrder(r);
                    menuReturn(r);
                    return 1;
                }
                if (state == 4)
                {
                    Console.Clear();

                    r.showIncome();
                    menuReturn(r);
                    return 1;
                }

                if (state == 5)
                {
                    return 0;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Incorrect input, type integer number from 1 to 5");
                Console.WriteLine();
                Menu.menu(r);
                return 1;
            }

            Console.Clear();
            return 0;
        }

    }
}
