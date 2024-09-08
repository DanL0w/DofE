using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit.Abstractions;

namespace AS_prog_FULL
{
    class Array_calc
    {
        public static void Run()
        {
            //List<int> ArrayInt = new List<int>();
            //bool sort = true;
            //while (sort == true)
            //{
            //    //sort = true;
            //    int Sorts = 0;
            //    for (int i = 0; i < ArrayInt.Count - 1; i++)
            //    {
            //        if (ArrayInt[i] > ArrayInt[i + 1])
            //        {
            //            int larger = ArrayInt[i];
                        //int smaller = ArrayInt[i + 1];
                        //ArrayInt[i] = smaller;
                        //ArrayInt[i + 1] = larger;
                        //Sorts++;
            //        }
            //    }
            //    if (Sorts == 0)
            //    {
            //        //sort = false;
            //    }
            //}
            List<string> ArrayStrings = new List<string>();
            for (int x = 0; x < ArrayStrings.Count-1; x++) 
            {
                for (int i = 0; i < ArrayStrings.Count - 1; i++)
                {
                    if ((ArrayStrings[i]).CompareTo(ArrayStrings[i+1]) == 1)
                    {
                        string larger = ArrayStrings[i];
                        string smaller = ArrayStrings[i + 1];
                        ArrayStrings[i] = smaller;
                        ArrayStrings[i + 1] = larger;
                    }     
                }
            }
            for(int x = 0; x < ArrayStrings.Count; x++)
            {
                Console.WriteLine(ArrayStrings[x]);
            }
        }
    }
}

