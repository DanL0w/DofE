using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AS_prog_FULL
{
    public class Selection01
    {
        public static void Run()
        {
            Question1(); //Passed
            //Question2(); Passed
            //Question3(); Passed
            //Question4(); Passed
        }

        public static void Question1()
        {
            int mark;
            string grade;
            Console.WriteLine("What is your mark? (0-100)");
            mark = Convert.ToInt32(Console.ReadLine());
            if (mark > 0 && mark < 100)
            {
                if (mark < 40)
                {
                    grade = "U";
                }
                else if (mark < 50)
                {
                    grade = "E";
                }
                else if (mark < 60)
                {
                    grade = "D";
                }
                else if (mark < 70)
                {
                    grade = "C";
                }
                else if (mark < 80)
                {
                    grade = "B";
                }
                else
                {
                    grade = "A";
                }
                Console.WriteLine($"Your grade is {grade}");
            }

            else
            {
                Console.WriteLine("Please enter an integer value 0-100");
            }
        }

        public static void Question2()
        {
            double price, discount, End_Price;
            Console.WriteLine("what is the price of the item you are buying?");
            price = Convert.ToDouble(Console.ReadLine());
            if (price < 1000)
            {
                discount = 1;
            }
            else if (price < 2500)
            {
                discount = 0.95;
            }
            else if (price < 5000)
            {
                discount = 0.9;
            }
            else if (price < 10000)
            {
                discount = 0.85;
            }
            else
            {
                discount = 0.8;
            }
            End_Price = Math.Round((discount * price), 2);
            Console.WriteLine($"The discounted price is £ {End_Price}");
        }

        public static void Question3()
        {
            int mark;
            string grade;
            Console.WriteLine("What is your mark? (0-100)");
            mark = Convert.ToInt32(Console.ReadLine());
            grade = "a";
            if (mark >= 0 && mark <= 100)
            {
                if (mark < 40)
                {
                    grade = "U";
                }
                else if (mark < 50)
                {
                    grade = "E";
                }
                else if (mark < 60)
                {
                    grade = "D";
                }
                else if (mark < 70)
                {
                    grade = "C";
                }
                else if (mark < 80)
                {
                    grade = "B";
                }
                else
                {
                    grade = "A";
                }
                Console.WriteLine(grade);
            }
            else
            {
                Console.WriteLine("error");
            }
                
        }

        public static void Question4()
        {
            {
                double price, discount, End_Price;
                Console.WriteLine("what is the price of the item you are buying?");
                price = Convert.ToDouble(Console.ReadLine());
                discount = 0;
                if (price >= 0 && price <= 25000)
                {
                    if (price < 1000)
                    {
                        discount = 1;
                    }
                    else if (price < 2500)
                    {
                        discount = 0.95;
                    }
                    else if (price < 5000)
                    {
                        discount = 0.9;
                    }
                    else if (price < 10000)
                    {
                        discount = 0.85;
                    }
                    else
                    {
                        discount = 0.8;
                    }
                    End_Price = Math.Round((discount * price), 2);
                    Console.WriteLine($"The discounted price is £ {End_Price}");
                }
                else
                {
                    Console.WriteLine("error");
                }
                

            }
        }
    }
}
