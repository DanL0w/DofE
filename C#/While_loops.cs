using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace AS_prog_FULL
{
    public class While_loops
    {
        public static void Run()
        {
            //Question1(); Passed
            //Question2(); Passed
            //Question3(); Passed
            //Question4(); Passed
        }

        public static void Question1()
        {
            Console.WriteLine("Enter password");
            string password = Convert.ToString(Console.ReadLine());

            while (password != "Barry")
            {
                Console.WriteLine("Password incorrect");
                password = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Entry gained!");
        }

        public static void Question2()
        {
            double total = 0, run = 0;
            while (run != 4)
            {
                total = total + Convert.ToDouble(Console.ReadLine());
                run++;
            }
            Console.WriteLine(total);
        }

        public static void Question3()
        {
            double A = 0, min = int.MaxValue, max = int.MinValue;
            A = Convert.ToDouble(Console.ReadLine());
            if (A == -1)
            {
                Console.WriteLine("Error, enter at least one non -1 value");
                return;
            }
            while ( A != -1)
            {
                if (A > max)
                {
                    max = A;
                }
                if (A < min)
                {
                    min = A;
                }
                A = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"Min = " + min + " Max = " + max);
        }

        public static void Question4()
        {
            int score = 0, run = 0;
            string guess = "Y", bigger = "Y";
            
            while (run <= 9)
            {
                Console.WriteLine("Is number 1 bigger than number 2  (Y/N)?");
                guess = Convert.ToString(Console.ReadLine());
                Random Rand = new Random();
                int RandNum1 = Rand.Next(1, 1000);
                int RandNum2 = Rand.Next(1, 1000);
                if (RandNum1 < RandNum2)
                {
                    bigger = "Y";
                }
                else
                {
                    bigger = "N";
                }
                if (guess == bigger)
                {
                    score++;
                }
                run++;
            }
            Console.WriteLine($"You scored {score}");
        }
    }
}
