using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Net;

namespace Day1{
    internal class FirstDay
    {
        static void Main(string[] args)
        {
            // take data from https://adventofcode.com/2022/day/1/input and put into string
            // split the string by the empty lines (/n/n)
            // for each group, split by the new lines (/n)
            // iterate through all groups and total them
            // display results in order from biggest to smallest

            //get the data from the input
            string file = "./input.txt";
            
            FileReader fr = new FileReader();
            int elfCounter = fr.totalElves(file);

            int[] allCals = fr.arraySize(file, elfCounter);

            List<int> elfList = allCals.ToList();

            elfList.Sort();
            elfList.Reverse();

            var res = elfList.Take(1);

            foreach (int str in res) {
                Console.WriteLine(str);
            }

            List<int> topThreeElves = elfList.Take(4).ToList();

            topThreeElves.RemoveAt(3);
            foreach (int str in topThreeElves) {
                Console.WriteLine(str);
            }
            int totalElves = topThreeElves.Sum();
            WriteLine("Top three elves: {0}", totalElves);
        }
    }
}