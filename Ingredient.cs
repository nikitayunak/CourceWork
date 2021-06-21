using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public class Ingredient
    {
        public string name;



        public static List<Ingredient> ingredients = new List<Ingredient>()
        {
            new Ingredient("dough"),
            new Ingredient("onion"),
            new Ingredient("lattuce"),
            new Ingredient("croutons"),
            new Ingredient("cheese"),
            new Ingredient("white sous"),
            new Ingredient("chicken"),
            new Ingredient("oil"),
            new Ingredient("tomato"),
            new Ingredient("cucumber"),
            new Ingredient("tomato sous"),
            new Ingredient("mushrooms"),
            new Ingredient("sausage"),
            new Ingredient("salmon"),
            new Ingredient("water"),
            new Ingredient("cream cheese"),
            new Ingredient("rice")
        };
        
        public Ingredient(string n)
        {
            name = n;
        }

        public void getInfo()
        {
            Console.WriteLine("{0}", name);
        }
    }
}
