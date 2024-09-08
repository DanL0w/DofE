using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Transactions;

namespace AS_prog_FULL
{
    class Sandbox
    {
        public static void Run()
        {
            Console.WriteLine("Enter you barcode");
            string barcode = Console.ReadLine();
            int result = 1;
            for (int i = 0; i < 6; i++)
            {
                result = result * Convert.ToInt32(barcode{i});
            }

        }

        public static void Run_Multiplicationtables()
        {
            Console.WriteLine("Input number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t");
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"{i} \t");
            }
            Console.WriteLine();
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"{i} \t");
                for (int j = 1; j <= x; j++)
                {
                    Console.Write($"{i*j} \t");
                }
                Console.WriteLine();
            }
        }
        public static void Run_shoppinglist()
        {
            List<string> Items = new List<string>();
            Items.Add("Pizza");
            Items.Add("Mayo");
            Items.Add("Bread");
            Items.Add("Pasta");
            Console.WriteLine(Items[2]);
            Items.RemoveAt(0);  
            int MayoIndex = Items.IndexOf("Mayo");
            Items[MayoIndex] = "Salad Cream";
            Console.WriteLine(MayoIndex);
            Console.WriteLine(Items.Count);

        }
        public static void ArrayMultiplcation()
        {
            Console.WriteLine("What is the width of the first array");
            int width1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the first array");
            int height1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the width of the second array");
            int width2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the second array");
            int height2 = Convert.ToInt32(Console.ReadLine());

            int size1 = width1 * height1;
            int size2 = height2 * width2;
            int resultantsize = width1 * height2;

            if (height1 == width2)
            {
                List<int> Matrix1 = new List<int>();
                List<int> Matrix2 = new List<int>();
                List<int> ProdArray = new List<int>();
                for (int i = 0; i < size1; i++)
                {
                    Console.WriteLine($"Enter item {i + 1} of the first array");
                    Matrix1.Add(Convert.ToInt32(Console.ReadLine()));
                }
                for (int i = 0; i < size2 ; i++)
                {
                    Console.WriteLine($"Enter item {i + 1} of the second array");
                    Matrix2.Add(Convert.ToInt32(Console.ReadLine()));
                }
                for (int i = 0; i < resultantsize; i++)
                {

                }
            }
            else
            {
                Console.WriteLine("They arent multiplictibly comfortable");
            }
        }
        public static void Run_printname ()
        {
            string Name = GetName();
        }
        
        public static string GetName()
        {
            Console.WriteLine("Enter your name");
            return Console.ReadLine();
        }
        public static void Digits10()
        {
            double a = 1;
            List<double> Answers = new List<double>(); ;
            for (int i = 0; i < 1000000000; i++)
            {
                if (a % 10 != 0 || Math.Floor(a / 10) % 9 != 0 || Math.Floor(a / 100) % 8 != 0 || Math.Floor(a / 1000) % 7 != 0 || Math.Floor(a / 10000) % 6 != 0 || Math.Floor(a / 100000) % 5 != 0 || Math.Floor(a / 1000000) % 4 != 0 || Math.Floor(a / 10000000) % 3 != 0 || Math.Floor(a / 100000000) % 2 != 0)
                {
                    Answers.Add(a);
                    a++;
                }
                else
                {
                    a++;
                }
            }
            Console.WriteLine(Answers);
        }
        public static void Run_Guessinggame()
        {
            Random Rand = new Random();
            int RandNum = Rand.Next(1, 100);
            Console.WriteLine("Welcome to the Magic Number guessing game! See how many guesses you take until you guess the magic number");
            Console.WriteLine("Enter your guess");
            int Guess = Convert.ToInt32(Console.ReadLine());
            int GuessCount = 0;
            while (RandNum != Guess && Guess >= 1 && Guess <= 100)
            {
                if (RandNum < Guess)
                {
                    Console.WriteLine("Too high! Try again");
                    Guess = Convert.ToInt32(Console.ReadLine());
                    GuessCount++;
                }
                else
                {
                    Console.WriteLine("Too low! Try again");
                    Guess = Convert.ToInt32(Console.ReadLine());
                    GuessCount++;
                }
            }
            Console.WriteLine($"it took you " + GuessCount + " attempts to guess the magic number! GAME OVER");
        }

        public static void Run_ForLoops()
        {
            //Array = fixed size
            string[] NamesArray = { "Dan", "Adam", "Bob" };
            // prints all 
            foreach (string Name in NamesArray)
            {
                Console.WriteLine(Name);
            }
            // same result as above
            for (int i = 0; i < NamesArray.Length; i++)
            {
                Console.WriteLine(NamesArray[i]);   
            }

            //List = variable size
            List<string> NamesList = new List<string>(); ;
            NamesList.Add("Dan");
            NamesList.Add("Adam");
            NamesList.Add("Bob");
            //prints all
            for(int i = 0; i < NamesList.Count; i++)
            {
                Console.WriteLine();
            }
            
        }
        public static void Run_SelectionStrings()
        {
            string Name1 = "Alpha";
            string Name2 = "Alpple";
            int CmpName1Name2 = Name1.CompareTo(Name2);
            if (CmpName1Name2 == -1)
                Console.WriteLine("Name1 is before Name2");
            else if (CmpName1Name2 == 1)
                Console.WriteLine("Name1 is after Name2");
            else if (CmpName1Name2 == 0)
                Console.WriteLine("Name1 and Name2 are equal");



            //string Name1 = "C";
            //string Name2 = "B";
            //int CmpName1Name2 = Name1.CompareTo(Name2);

            //if (CmpName1Name2 == -1)
            //    Console.WriteLine("Compare is -1");
            //else if (CmpName1Name2 == 0)
            //    Console.WriteLine("Compare is 0");
            //else if (CmpName1Name2 == 1)
            //    Console.WriteLine("Compare is 1");

        }
    }
}
