using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml.Linq;

namespace AS_prog_FULL
{
    public class Strings01
    {
        public static void Run()
        {
            //Question1(); Passed
            //Question2(); Passed
            //Question3(); Passed
            //Question4(); Passed
            //Question5(); Passed
        }

        public static void Question1()
        {
            string name;
            Console.WriteLine("what is your name");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"{name.Length}");
        }

        public static void Question2()
        {
            string name;
            Console.WriteLine("What is your name?");
            name = Convert.ToString(Console.ReadLine());
            if (name.Length == 1)
                Console.WriteLine("Hello " + name + ". Your name has " + name.Length + " character and your initial is " + name[0]);
            else
                Console.WriteLine("Hello " + name + ". Your name has " + name.Length + " characters and your initial is " + name[0]);
        }
 

        public static void Question3()
        {
            string number;
            Console.WriteLine("Enter a phone number");
            number = Convert.ToString(Console.ReadLine());
            Console.WriteLine("+44 " + number.Substring(1));

        }

        public static void Question4()
        {
            string DoB, Day, Month, Year;
            Console.WriteLine("What's your DoB (DD/MM/YYYY)?");
            DoB = Convert.ToString(Console.ReadLine());
            Day = DoB.Substring(0, 2);
            Month = DoB.Substring(3, 2);
            Year = DoB.Substring(6, 4);
            Console.WriteLine($"You were born on the {Day}th day of the {Month}th month in {Year}");
        }

        public static void Question5()
        {
            string DoB, Day, MonthName, Suffix;
            int Dayint, Year, Month, Month_Length;
            string[] months = {"Jan", "Feb","Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] Days_In_Month = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("What's your DoB (DD/MM/YYYY)?");
            DoB = Console.ReadLine();
            try
            {
                Dayint = Convert.ToInt32(DoB.Substring(0, 2));
                Day = Convert.ToString(DoB.Substring(0, 2));
                Month = Convert.ToInt32(DoB.Substring(3, 2)); // "09" => 9
                MonthName = months[Month - 1];
                Month_Length = Days_In_Month[Month - 1];
                Year = Convert.ToInt32(DoB.Substring(6, 4));

            }
            catch
            {
                Console.WriteLine("Invalid date");
                return;
            }
            Dayint = Convert.ToInt32(DoB.Substring(0, 2));
            Month = Convert.ToInt32(DoB.Substring(3, 2)); // "09" => 9
            MonthName = months[Month - 1];
            Month_Length = Days_In_Month[Month - 1];
            Year = Convert.ToInt32(DoB.Substring(6, 4));
            if (Dayint== 1 || Dayint == 21 || Dayint == 31)
            {
                Suffix = "st";
            }
            else if (Dayint == 2 || Dayint == 22)
            {
                Suffix = "nd";
            }
            else if (Dayint == 3 || Dayint == 23)
            {
                Suffix = "rd";
            }
            else
            {
                Suffix = "th";
            }
            if (Dayint < 10)
            {
                //Day = Convert.ToString(Day);
            }
            if (Dayint == 29 && MonthName == "Feb" && Year % 4 != 0)
            {
                Console.WriteLine($"{Year} was not a leap year");
            }
            else if (Dayint > Month_Length)
            {
                Console.WriteLine("Invalid date");
            }
            else
            {
                Console.WriteLine($"You were born on the {Day}{Suffix} day of {MonthName} in {Year}");
            }
        }
    }
}
