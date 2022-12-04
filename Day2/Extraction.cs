using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Day2
{
    public class Extraction
    {
        public int totalElves(string file){
            int elfCounter = 0;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        elfCounter++;
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                WriteLine("The file could not be read:");
                WriteLine(e.Message);
            }
            return elfCounter;
        }

        public int[] game(string file, int size){
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            const int WIN = 6;
            const int DRAW = 3;
            const int LOSE = 0;

            int[] result = new int[size];
            int lineNum = 0;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        // A = Rock = 1
                        // B = Paper = 2
                        // C = Scissors = 3
                        // X = Rock = 1
                        // Y = Paper = 2
                        // Z = Scissors = 3
                        // win = 6
                        // draw = 3
                        // lose = 0
                        switch (line) {
                            case "A X":
                                result[lineNum] = ROCK + DRAW;
                                break;
                            case "A Y":
                                result[lineNum] = PAPER + WIN;
                                break;
                            case "A Z":
                                result[lineNum] = SCISSORS + LOSE;
                                break;
                            case "B X":
                                result[lineNum] = ROCK + LOSE;
                                break;
                            case "B Y":
                                result[lineNum] = PAPER + DRAW;
                                break;
                            case "B Z":
                                result[lineNum] = SCISSORS + WIN;
                                break;
                            case "C X":
                                result[lineNum] = ROCK + WIN;
                                break;
                            case "C Y":
                                result[lineNum] = PAPER + LOSE;
                                break;
                            case "C Z":
                                result[lineNum] = SCISSORS + DRAW;
                                break;
                        }
                        lineNum++;
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                WriteLine("The file could not be read:");
                WriteLine(e.Message);
            }
            return result;
        }

        public int[] correctedGame(string file, int size){
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            const int WIN = 6;
            const int DRAW = 3;
            const int LOSE = 0;

            int[] result = new int[size];
            int lineNum = 0;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        // A = Rock = 1
                        // B = Paper = 2
                        // C = Scissors = 3
                        // X = LOSE = 6
                        // Y = DRAW = 0
                        // Z = WIN = 3
                        switch (line) {
                            case "A X": // LOSE
                                result[lineNum] = SCISSORS + LOSE;
                                break;
                            case "A Y": // DRAW
                                result[lineNum] = ROCK + DRAW;
                                break;
                            case "A Z": // WIN
                                result[lineNum] = PAPER + WIN;
                                break;
                            case "B X": // LOSE
                                result[lineNum] = ROCK + LOSE;
                                break;
                            case "B Y": // DRAW
                                result[lineNum] = PAPER + DRAW;
                                break;
                            case "B Z": // WIN
                                result[lineNum] = SCISSORS + WIN;
                                break;
                            case "C X": // LOSE
                                result[lineNum] = PAPER + LOSE;
                                break;
                            case "C Y": // DRAW
                                result[lineNum] = SCISSORS + DRAW;
                                break;
                            case "C Z": // WIN
                                result[lineNum] = ROCK + WIN;
                                break;
                        }
                        lineNum++;
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                WriteLine("The file could not be read:");
                WriteLine(e.Message);
            }
            return result;
        }
    }
}