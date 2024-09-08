using System;
using System.Collections.Generic;
using System.Text;

namespace AS_prog_FULL
{
    public class Selection02
    {
        public static void Run()
        {
            //Question1(); Passed
            //Question2(); Passed
            //Question3(); Passed
        }

        public static void Question1()
        {
            Console.WriteLine("Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            if (Num % 2 == 1)
            {
                Console.WriteLine("odd");
            }

        }

        public static void Question2()
        {
            Console.WriteLine("Enter your age in years:");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you passed your test? (Y/N):");
            string test = Console.ReadLine();
            if (test == "Y" && Age > 21)
            {
                Console.WriteLine("You are allowed to drive the minibus");
            }
            else
            {
                Console.WriteLine("You are not allowed to drive the minibus");
            }
        }

        public static void Question3()
        {
            string Name1 = Console.ReadLine();
            string Name2 = Console.ReadLine();
            string Name3 = Console.ReadLine();
            char char1 = Convert.ToChar(Name1.Substring(0, 1));
            char char2 = Convert.ToChar(Name2.Substring(0, 1));
            char char3 = Convert.ToChar(Name3.Substring(0, 1));
            if (char1 <= char2 && char2 <= char3)
            {
                Console.WriteLine($"{Name1} {Name2} {Name3}");
            }
            else if (char1 <= char3 && char3 <= char2)
            {
                Console.WriteLine($"{Name1} {Name3} {Name2}");
            }
            else if (char2 <= char1 && char1 <= char3)
            {
                Console.WriteLine($"{Name2} {Name1} {Name3}");
            }
            else if (char2 <= char3 && char3 <= char1)
            {
                Console.WriteLine($"{Name2} {Name3} {Name1}");
            }
            else if (char3 <= char1 && char1 <= char2)
            {
                Console.WriteLine($"{Name3} {Name1} {Name2}");
            }
            else if (char3 <= char2 && char2 <= char1)
            {
                Console.WriteLine($"{Name3} {Name2} {Name1}");
            }
        }
    }
}
