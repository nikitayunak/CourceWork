using System;
using System.Collections.Generic;
using MyClass;

namespace kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant rest = new Restaurant("Cherry Lake", 0);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu.menu(rest);
        }
    }
}
