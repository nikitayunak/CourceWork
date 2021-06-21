using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public class Order
    {

        public static int menuOrder(Restaurant restaurant)
        {
            Console.WriteLine("Placing a new order");
            Console.WriteLine();

            Dish chosen = new Dish("", 0, null);
            List<Dish> final = new List<Dish>();

            Console.WriteLine("How many dishes you want to order: ");



            int count = 0;
            string input = Console.ReadLine();

            try
            {
                count = Convert.ToInt32(input);
                if (count <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Incorrect input, try again");
                Console.WriteLine();
                menuOrder(restaurant);
            }

            List<float> portion = new List<float>();
            float port = 0;
            for (int c = 0; c < count; c++)
            {
                Dish.priceList();
                Console.WriteLine("Watch price list and choose what you want to order:");
                Console.WriteLine();

                string order = Console.ReadLine();
                for (int i = 0; i < Dish.dishes.Count; i++)
                    if (order == Dish.dishes[i].name)
                    {
                        final.Add(Dish.dishes[i]);
                    }

                Console.WriteLine();
                Console.WriteLine("Choose portion (grams) (100/500/1000): ");

                string input_p = Console.ReadLine();
                try
                {
                    port = Convert.ToInt32(input_p);
                    if (port == 100 | port == 500 | port == 1000)
                    {
                        portion.Add(port);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input, try again");
                    Console.WriteLine();
                    menuOrder(restaurant);
                }

            }




            orderConfirm(final, portion, restaurant);
            return 1;
        }

        public static int orderConfirm(List<Dish> order, List<float> portion, Restaurant r)
        {
            float price = 0;
            for (int i = 0; i < order.Count; i++)
            {
                price = price + (order[i].cost * portion[i] / 100);


            }
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Your order is accepted, total price:");
            Console.WriteLine(price);
            Console.WriteLine();

            r.getIncome(price);
            return 1;
        }


    }

}
