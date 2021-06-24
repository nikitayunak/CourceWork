using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public class Dish
    {
        public string name;
        public float cost;

        public List<Ingredient> needed_ing;
        public static List<Dish> dishes = new List<Dish>()
        {
            new Dish("Caesar", 50, new List<Ingredient>(){ Ingredient.ingredients[2], Ingredient.ingredients[3], Ingredient.ingredients[4], Ingredient.ingredients[5], Ingredient.ingredients[6], Ingredient.ingredients[8] }),
            new Dish("Pizza", 100, new List<Ingredient>(){ Ingredient.ingredients[0], Ingredient.ingredients[10], Ingredient.ingredients[11], Ingredient.ingredients[12], Ingredient.ingredients[4] }),
            new Dish("Philadelphia", 120, new List<Ingredient>(){ Ingredient.ingredients[16], Ingredient.ingredients[15], Ingredient.ingredients[13], Ingredient.ingredients[9] })
        };

        public Dish(string n, float c, List<Ingredient> l)
        {
            name = n;
            cost = c;
            needed_ing = l;
        }


        public static int menuCreate()
        {
            Console.WriteLine("Adding new dish");
            Console.WriteLine();

            List<Ingredient> temp = new List<Ingredient>();
            Console.WriteLine("Dish name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Dish price for 100g: ");

            float cost = 0;
            string input = Console.ReadLine();

            if (float.TryParse(input, out cost))
            {
                try
                {
                    if (float.Parse(input) <= 0)
                    {
                        throw new Exception("Negative price");
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input, try again");
                    Console.WriteLine();
                    menuCreate();
                }

                Console.WriteLine();
                Console.WriteLine("How many ingredients do you want to use: ");
                int count = 0;
                string input_num_i = Console.ReadLine();
                try
                {
                    count = Convert.ToInt32(input_num_i);
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
                    menuCreate();
                }



                Console.WriteLine();

                List<string> all = new List<string>();
                for (int ing = 0; ing < Ingredient.ingredients.Count; ing++)
                {
                    all.Add(Ingredient.ingredients[ing].name);
                }

                for (int n = 0; n < count; n++)
                {

                    Console.WriteLine("Choose ingredient {0}: ", n + 1);

                    for (int i = 0; i < all.Count; i++)
                    {

                        Console.WriteLine("Ingredient: {0}", all[i]);



                    }

                    string choice = Console.ReadLine();

                    for (int i = 0; i < Ingredient.ingredients.Count; i++)
                    {
                        if (choice == Ingredient.ingredients[i].name)
                        {
                            temp.Add(Ingredient.ingredients[i]);
                            all.Remove(Ingredient.ingredients[i].name);


                        }
                    }

                }

                createDish(name, cost, temp);
                Console.Clear();
                Console.WriteLine("Dish was successfully added to the price list");
                Console.WriteLine();
                return 1;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect input, try again");
                Console.WriteLine();
                menuCreate();
            }

            return 1;

        }
        public static int createDish(string n, float c, List<Ingredient> ings)
        {
            Dish.dishes.Add(new Dish(n, c, ings));
            return 1;
        }
        public static int priceList()
        {
            Console.Clear();
            Console.WriteLine("Price list");
            Console.WriteLine();

            int[] portions = new int[3] { 100, 500, 1000 };
            for (int i = 0; i < dishes.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine(dishes[i].name);
                Console.WriteLine();
                Console.WriteLine("Ingredients: ");
                for (int n = 0; n < dishes[i].needed_ing.Count; n++)
                {
                    Console.WriteLine(dishes[i].needed_ing[n].name);
                }
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    int portion = portions[j];
                    float price = dishes[i].cost * portion / 100;
                    Console.WriteLine("Portion: {0}, Price: {1}", portion, price);
                }
                Console.WriteLine("--------------------------");
                Console.WriteLine();
            }

            Console.WriteLine();
            return 1;
        }
    }
}
