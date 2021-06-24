using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public class Restaurant
    {
        public string name;
        public float income;
        public float order_count;
        public float dish_count;
        public Restaurant(string n, float m)
        {
            name = n;
            income = m;
            order_count = 0;
            dish_count = 0;
        }

        public float getIncome(float amount)
        {
            income = income + amount;
            return income;
        }

        public float getOrderCount(float amount)
        {
            order_count = order_count + amount;
            return order_count;
        }

        public float getDishCount(float amount)
        {
            dish_count = dish_count + amount;
            return dish_count;
        }

        public int showIncome()
        {
            Console.WriteLine($"Restaurant income: {income}");
            return 1;
        }

        public int showOrderCount()
        {
            Console.WriteLine($"Orders for today: {order_count}");
            return 1;
        }

        public int showDishCount()
        {
            Console.WriteLine($"Ordered dishes for today: {dish_count}");
            return 1;
        }

        public string getName()
        {
            return name;
        }
    }
}