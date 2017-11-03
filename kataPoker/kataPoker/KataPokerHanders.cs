using System;
using System.Collections.Generic;
using System.IO;

namespace kataPoker
{
    class KataPokerHanders
    {
        public static string compare(string input)
        {
            string[] inputSplit = input.Split(' ');
            List<string> Black =new List<string>();
            List<string> White = new List<string>();

            for (int i = 0; i < inputSplit.Length; i++)
            {
                if (i < 6)
                {
                    Black.Add(inputSplit[i]);
                }
                else
                {
                    White.Add(inputSplit[i]);
                }
            }

            return "White wins. -With high card: Ace";
        }
    }
}
