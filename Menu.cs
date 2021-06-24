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
        public static void menuChefReturn(Restaurant r)
        {
            Console.WriteLine();
            Console.WriteLine("Return to the chef's menu - 0");
            Console.WriteLine();

            int state_menu = 1;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out state_menu) && state_menu == 0)
            {
                Console.Clear();
                Menu.menuChef(r);
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Incorrect input, try again");
                Console.WriteLine();

                menuChefReturn(r);
            }
        }
        public static void menuAdmReturn(Restaurant r)
        {
            Console.WriteLine();
            Console.WriteLine("Return to the administrator's menu - 0");
            Console.WriteLine();

            int state_menu = 1;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out state_menu) && state_menu == 0)
            {
                Console.Clear();
                Menu.menuAdm(r);
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Incorrect input, try again");
                Console.WriteLine();

                menuAdmReturn(r);
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
            Console.WriteLine("Make a new order - 2");
            Console.WriteLine("Leave restaurant - 3");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Switch to chef's menu - 4");
            Console.WriteLine("Switch to administrator's menu - 5");
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

                    Order.menuOrder(r);
                    menuReturn(r);
                    return 1;
                }
                if (state == 3)
                {
                    return 0;
                }
                if (state == 4)
                {
                    Console.Clear();

                    Console.WriteLine("Enter password: ");
                    string pass = Console.ReadLine();
                    if (pass == "chef123")
                    {
                        menuChef(r);
                        return 1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong password");
                        menu(r);
                    }
                    
                    return 0;
                }

                if (state == 5)
                {
                    Console.Clear();

                    Console.WriteLine("Enter password: ");
                    string pass = Console.ReadLine();
                    if (pass == "admin123")
                    {
                        menuAdm(r);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong password");
                        menu(r);
                    }
               
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

        public static int menuChef(Restaurant r)
        {
            
            Console.Clear();
            Console.WriteLine("Chef's menu");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Add new dish - 1");
            Console.WriteLine("Watch ingredients list - 2");
            Console.WriteLine("Switch to customer's menu - 3");
            Console.WriteLine("Switch to administrator's menu - 4");
            Console.WriteLine();

            int state = 0;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out state) && state >= 1 && state <= 4)
            {
                Console.Clear();

                if (state == 1)
                {


                    Console.Clear();

                    Dish.menuCreate();
                    menuChefReturn(r);
                    return 1;

                }
                if (state == 2)
                {
                    Ingredient.ingList();

                    menuChefReturn(r);

                    return 1;
                }
                if (state == 3)
                {
                    Console.Clear();
                    menu(r);

                    return 0;
                }
                if (state == 4)
                {
                    Console.Clear();

                    Console.WriteLine("Enter password: ");
                    string pass = Console.ReadLine();
                    if (pass == "admin123")
                    {
                        menuAdm(r);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong password");
                        menu(r);
                    }

                    return 0;
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Incorrect input, type integer number from 1 to 4");
                Console.WriteLine();
                Menu.menuChef(r);
                return 1;
            }
            
            Console.Clear();
            return 0;
        }
        public static int menuAdm(Restaurant r)
        {
            
                Console.Clear();
                Console.WriteLine("Administrator's menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Watch income - 1");
                Console.WriteLine("Watch number of orders for today - 2");
                Console.WriteLine("Watch number of ordered dishes for today - 3");
                Console.WriteLine("Switch to customer's menu - 4");
                Console.WriteLine("Switch to chef's menu - 5");
                Console.WriteLine();

                int state = 0;
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out state) && state >= 1 && state <= 5)
                {
                    Console.Clear();

                    if (state == 1)
                    {


                        Console.Clear();

                        r.showIncome();
                        menuAdmReturn(r);
                        return 1;

                    }
                    if (state == 2)
                    {
                        Console.Clear();

                        r.showOrderCount();
                        menuAdmReturn(r);
                        return 1;
                    }
                    if (state == 3)
                    {
                        Console.Clear();

                        r.showDishCount();
                        menuAdmReturn(r);
                        return 1;
                    }
                    if (state == 4)
                    {
                        Console.Clear();

                        menu(r);

                        return 0;
                    }
                    if (state == 5)
                    {
                    Console.Clear();

                    Console.WriteLine("Enter password: ");
                    string pass = Console.ReadLine();
                    if (pass == "chef123")
                    {
                        menuChef(r);
                        return 1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong password");
                        menu(r);
                    }

                    return 0;
                }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Incorrect input, type integer number from 1 to 5");
                    Console.WriteLine();
                    Menu.menuAdm(r);
                    return 1;
                }
            
            Console.Clear();
            return 0;
        }
    }
}
