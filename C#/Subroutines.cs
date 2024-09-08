using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AS_prog
{
    public class Subroutines
    {
        public static void Welcome()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Welcome to the TV Listings Program");
            Console.WriteLine("Today's date: {0}", DateTime.Now.ToString("dd/M/yyyy"));
            Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
            Console.WriteLine("========================================");
        }
        public static string AddProg()
        {
            Console.WriteLine("Enter the name for a TV program:");
            string program = Console.ReadLine();
            if (program.Length >= 4 )
            {
                return program;
            }
            else
            {
                return "";
            }
        }
        public static string AddTime(string Programs)
        {
            Console.WriteLine("Enter the start time for {0}:", Programs);
            string time = Console.ReadLine();
            if (time.Length == 5)
            {
                return time;
            }
            else
            {
                return ""; 
            }
        }
        public static void DisProg(string Program, string Time)
        {
            Console.WriteLine();
            Console.WriteLine("{0} is on tomorrow at {1}", Program, Time);
            Console.WriteLine("Press 'Enter' to get the next program");
            Console.ReadLine();
            Console.WriteLine();
        }
        public static void RunImproved()
        {
            List<string> programs = new List<string>() { "coronation street", "emmerdale", "hollyoaks" };
            List<string> times = new List<string>() { "20:00", "19:00", "18:30" };
            string program = AddProg();
            programs.Add(program);
            times.Add(AddTime(program));

            for (int i = 0; i < 4; i++)
            {
                Welcome();
                DisProg(programs[i], times[i]);
            }
        }


    }
}
