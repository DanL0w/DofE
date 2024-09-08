using System;
using System.Collections.Generic;
using System.Text;

namespace AS_prog_FULL
{
    public class For_loops
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
            string sentence = Convert.ToString(Console.ReadLine());
            char[] characters = sentence.ToCharArray();
            int NumE = 0;
            foreach (char character in characters ) 
            {
                if(character == 'e' || character == 'E')
                {
                    NumE = NumE + 1;
                }
            }
            Console.WriteLine($"The letter e appears {NumE} times(s)");
        }

        public static void Question2()
        {
            string sentence = (Convert.ToString(Console.ReadLine()));
            sentence = sentence.ToLower();
            char[] characters = sentence.ToCharArray();
            int Num = 0;
            foreach (char character in characters)
            {
                if (character == 'e'|| character == 'a' || character == 'i' || character == 'o' ||  character == 'u')
                {
                    Num = Num + 1;
                }
            }
            Console.WriteLine($"The letter e appears {Num} times(s)");
        }

        public static void Question3()
        {
            string sentence = Convert.ToString(Console.ReadLine());
            int NumE = 1;
            if (sentence == "")
            {
                Console.WriteLine("0");
                return;
            }
            foreach (char character in sentence)
            {
                if (character == ' ')
                {
                    NumE = NumE + 1;
                }
                Console.WriteLine($"The letter e appears {NumE} times(s)");
            }
        }

        public static void Question4()
        {
            int Over = 0;
            int Ball = 0;
            for (int i = 0; i < 6; i++)
            {
                Ball = Convert.ToInt32(Console.ReadLine());
                if (Ball < 0)
                {
                    Console.WriteLine("Error: negative score");
                    return;
                }
                else if (Ball > 6)
                {
                    Console.WriteLine("Error: invalid score");
                    return;
                }
                Over = Over + Ball;
            }
            Console.WriteLine(Over);
        }
    }
}
