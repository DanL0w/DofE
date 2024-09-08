using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AS_prog_FULL
{
    public class Types_and_math
    {
        public static void Run()
        {
            //Question1(); Passed
            //Question2(); Passed
            //Question3(); Passed
        }

        public static void Question1()
        {
            int MoneyLeft = 50000;
            int food, trips, presents;
            Console.WriteLine("How much (in pounds) did you spend on food?");
            food = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much did you spend on trips?");
            trips = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much did you spend on presents?");
            presents = Convert.ToInt32(Console.ReadLine()); 
            MoneyLeft = MoneyLeft - food - trips - presents;
            Console.WriteLine($"You have £{MoneyLeft}");
        }

        public static void Question2()
        {
            int Players, seating, full, remaining;
            Console.WriteLine("How many players are there?");
            Players = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the seating capacity of the coaches?");
            seating = Convert.ToInt32(Console.ReadLine());
            full = Players / seating;
            remaining = Players % seating;
            Console.WriteLine($"{full} coaches are needed. The last coach has {remaining} seats left.");
        }

        public static void Question3()
        {
            int Start_Minutes, Start_Hours, Duration_Minutes, Duration_Hours, End_Minutes, End_Hours;
            Console.WriteLine("At what time in hours does the event start?");
            Start_Hours = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("At what time in minutes does the event start?");
            Start_Minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours does the event last?");
            Duration_Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many minutes does the event last?");
            Duration_Minutes = Convert.ToInt32(Console.ReadLine());
            End_Hours = ((Start_Minutes + Duration_Minutes + ((Start_Hours + Duration_Hours) * 60)) / 60) % 12;
            End_Minutes = (Start_Minutes + Duration_Minutes + ((Start_Hours + Duration_Hours) * 60)) % 60;
            Console.WriteLine($"You will finish at {End_Hours}:{End_Minutes}");

        }
    }
}
