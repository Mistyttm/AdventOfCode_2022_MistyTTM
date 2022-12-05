using System;
using static System.Console;

namespace Day4 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compare c = new Compare();
            int groups = c.internalGroups("input.txt", c.totalElves("input.txt"));
            int overlaps = c.overlapping("input.txt", c.totalElves("input.txt"));
            WriteLine("Total assignment pairs that fully contain each other: {0}", groups);
            WriteLine("Total assignment pairs that overlap: {0}", overlaps);
        }
    }
}