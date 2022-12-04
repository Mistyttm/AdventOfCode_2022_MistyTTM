using System;
using static System.Console;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FILE = "./input.txt";

            Comparer c = new Comparer();
            int totalRucksacks = c.totalElves(FILE);

            int[] result = c.commonLetters(FILE, totalRucksacks);
            List<int> commonLetters = result.ToList();
            int letterSum = commonLetters.Sum();
            WriteLine("The sum of the common letters is: " + letterSum);

            int[] badges = c.commonBadges(FILE, totalRucksacks);
            List<int> badgesList = badges.ToList();
            int badgeSum = badgesList.Sum();
            WriteLine("The sum of the common badges is: " + badgeSum);
        }
    }
}