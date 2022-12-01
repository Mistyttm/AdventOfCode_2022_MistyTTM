using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Day1
{
    public class FileReader
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
                        if (line == ""){
                            elfCounter++;
                        }
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

        public int[] arraySize(string file, int size){
            int calorieCount = 0;
            int[] calories = new int[size];
            int temp = 0;
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
                        if (line == ""){
                            calories[calorieCount] = temp;
                            calorieCount++;
                            temp = 0;
                        } else {
                            int lineInt = Int32.Parse(line);
                            temp += lineInt;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                WriteLine("The file could not be read:");
                WriteLine(e.Message);
            }
            return calories;
        }
    }
}