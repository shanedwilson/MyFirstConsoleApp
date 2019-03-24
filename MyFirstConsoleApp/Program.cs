using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What value would you like to enter?");
            var input = Console.ReadLine();

            int? x = 1;
            bool y = true;
            DateTime z = new DateTime(2019, 7, 12);
            string s = "abc";
            double f = 12.34;

            object o = new { MyProperty = 123 };
            string[] stringArray = new[] { "abc", "def", "ghi"};

            var myList = new List<int> { 1, 1, 1, 1, 1 };
            myList.Remove(1);

            if (x == 0)
            {
                Console.WriteLine("yep, it's zero");
            }
            else if (x == 1)
            {
                Console.WriteLine("Yep, it's one.");
            }
            else
            {
                Console.WriteLine("nope, it's not zero or one");
            }

            switch (x)
            {
                case 0:
                    Console.WriteLine("yep, it's zero");
                    break;
                case 1:
                    Console.WriteLine("yep, it's one");
                    break;
                case 2:
                    Console.WriteLine("yep, it's two");
                    break;
                default:
                    Console.WriteLine("rep it was none of those");
                    break;
            }

            var myNumberIsOne = x == 1 ? true : false;

            foreach (var currentNumber in myList)
            {
                Console.WriteLine($"yep, it was {currentNumber}");
            }

            try
            {
                myList = null;
                myList.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
