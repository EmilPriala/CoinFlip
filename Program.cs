using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coins();
        }

        private static void Coins()
        {
            int stake;
            int goal;
            int times = 10000;
            int wins = 0, losses = 0;


            Random rnd = new Random();

            for (int i = 1; i <= times; i++)
            {

                stake = 30;
                goal = 100;

                while (!(stake == 0 || goal == stake))
                {
                    if (rnd.Next(2) == 0)
                    {
                        stake++;
                    }
                    else
                    {
                        stake--;
                    }
                }
                if (stake == 0)
                {
                    losses++;
                }
                else if (stake == goal)
                {
                    wins++;
                }
            }

            Console.WriteLine($"Wins: {wins}, Losses: {losses}");
        }
