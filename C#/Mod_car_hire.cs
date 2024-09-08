using System;
using System.Collections.Generic;
using System.Text;

namespace AS_prog_FULL
{
    public class Mod_car_hire
    {
        public static void Run()
        {
            Console.WriteLine("Eavson Car Hire Company");
            Console.WriteLine("Enter car make?");
            string Make = Console.ReadLine();
            Console.WriteLine("Enter car model?");
            string Model = Console.ReadLine();
            Console.WriteLine("What's the rate?");
            int Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Days     Charge (£)");
            for(int i = 0; i <14; i++)
            {
                Console.WriteLine($"{i}     {i * Rate}");
            }
            Console.WriteLine($"A 10% discount is available for 14 day hires = £{Convert.ToInt32(Rate * 1260) / 100.0} a saving of £{Convert.ToInt32(Rate*1400)/1000.0}");
            if (Make == "VW")
            {
                Console.WriteLine("YOU GET A FREE ATLAS WITH THIS HIRE");
            }
        }
    }
}
