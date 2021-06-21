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
        public Restaurant(string n, float m)
        {
            name = n;
            income = m;
        }

        public float getIncome(float amount)
        {
            income = income + amount;
            return income;
        }

        public int showIncome()
        {
            Console.WriteLine($"Restaurant income: {income}");
            return 1;
        }

        public string getName()
        {
            return name;
        }
    }
}