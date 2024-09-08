using System;
using System.Collections.Generic;
using System.Text;

namespace AS_prog_FULL
{
    public class Supermarket_sweep
    {
        public static void Run()
        {
            const int SECTIONS = 5;
            const int AISLES = 6;

            char[,] Supermarket = { { 'I', 'X', 'I', 'I', 'S', 'X' },
                                    { 'X', 'X', 'X', 'S', 'X', 'I' },
                                    { 'X', 'X', 'S', 'X', 'X', 'I' },
                                    { 'S', 'X', 'S', 'X', 'S', 'S' },
                                    { 'X', 'S', 'S', 'X', 'X', 'S' }
            };

            Random rand = new Random();
            int randaisle = rand.Next(0, AISLES);
            Console.WriteLine(randaisle);
            int infl = 0;
            int s = 0;
            for (int i = 0; i < SECTIONS; i++)
            {
                char Item = Supermarket[i, randaisle];
                if (Item  == 'I')
                {
                    infl++;
                }
                else if (Item == 'S')
                {
                    s++;
                }
                ; 
            }
            Console.WriteLine($"There were {infl} inflatables items");
            Console.WriteLine($"There were {s} list items");
        }
    }
}
