using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Text;
using System.Transactions;

namespace AS_prog_FULL
{
    public class Ext_coin_calc
    {
        public static void Run()
        {
            Console.WriteLine("Enter value:");
            double A = Convert.ToDouble(Console.ReadLine());
            int Value = Convert.ToInt32(A * 100);
            int[] Coins = { 0, 0, 0, 0, 0};
            int[] CoinsValue = { 100, 50, 20, 5, 1 };
            int leftover = Value;
            for (int i = 0; i < CoinsValue.Length; i++)
            {
                Coins[i] = leftover / CoinsValue[i];
                leftover = leftover % CoinsValue[i];
                if (Coins[i] > 0)
                {
                    if (CoinsValue[i] >= 100)
                    {
                        Console.WriteLine($"£" + CoinsValue[i] / 100 + ": " + Coins[i]);
                    }
                    else
                    {
                        Console.WriteLine($"" + CoinsValue[i] + "p: " + Coins[i]);
                    }
                }
            }





            //foreach (int Coin in Coins)
            //{
            //    CurrentCoin = CoinsValue[X];
            //    while (Value >= CurrentCoin)
            //    {
            //        Value = Value - CurrentCoin;
            //        Coin ++ ;
            //    }
            //    X = X + 1;
            //}
            //foreach (int Coin in Coins)
            //{
            //    Console.WriteLine($"£" + CoinsValue + ":" + Coin);
            //}



        }
    }
}
