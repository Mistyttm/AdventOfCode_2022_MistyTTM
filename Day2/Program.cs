using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args){
            // get input from input.txt

            string input = "./input.txt";

            Extraction e = new Extraction();
            int totalElves = e.totalElves(input);

            WriteLine("Total Elves: {0}", totalElves);

            int[] game = e.game(input, totalElves);
            List<int> gameList = game.ToList();
            int totalWins = gameList.Sum();
            WriteLine("Total Score: {0}", totalWins);

            int[] correctedGame = e.correctedGame(input, totalElves);
            List<int> correctedGameList = correctedGame.ToList();
            int correctedTotalWins = correctedGameList.Sum();
            WriteLine("Corrected Total Score: {0}", correctedTotalWins);
        }
    }
}
