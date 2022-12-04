using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Day3
{
    public class Comparer
    {
        private const string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        // get input.txt
        // go line by line, split in half and find the identical letters in each part
        // add the common letters as an integer in ALPHABET to a list
        // return the sum of the list

        public int totalElves(string file){
            int elfCounter = 0;
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
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

        public int[] commonLetters(string file, int size){
            int[] result = new int[size];
            int elfCounter = 0;
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null){
                        int stringLength = line.Length;
                        string firstHalf = line.Substring(0, stringLength/2);
                        string secondHalf = line.Substring(stringLength/2, stringLength/2);

                        for (int i = 0; i < firstHalf.Length; i++){
                            for (int j = 0; j < secondHalf.Length; j++){
                                if (firstHalf[i] == secondHalf[j]){
                                    result[elfCounter] = (ALPHABET.IndexOf(firstHalf[i]) + 1);
                                    break;
                                }
                            }
                        }
                        elfCounter++;
                    }
                }
            }
            catch (Exception e)
            {
                WriteLine("The file could not be read:");
                WriteLine(e.Message);
            }
            return result;
        }

        public int[] commonBadges(string file, int size){
            int[] result = new int[size/3];
            int elfCounter = 0;
            string[] elfBadges = new string[3];
            int elfBadgeCount = 0;
            try{
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null){
                        if (elfBadges[2] == null){
                            elfBadges[elfBadgeCount] = line;
                            elfBadgeCount++;
                        } else {
                            for (int i = 0; i < elfBadges[0].Length; i++){
                                for (int j = 0; j < elfBadges[1].Length; j++){
                                    for (int k = 0; k < elfBadges[2].Length; k++){
                                        if (elfBadges[0][i] == elfBadges[1][j] && elfBadges[1][j] == elfBadges[2][k]){
                                            result[elfCounter] = (ALPHABET.IndexOf(elfBadges[0][i]) + 1); // I DON"T FUCKING KNOW HOW IM 583 SHORT AAAAAA
                                        }
                                    }
                                }
                            }
                            elfCounter++;
                            elfBadges[0] = null;
                            elfBadges[1] = null;
                            elfBadges[2] = null;
                            elfBadgeCount = 0;
                        }
                    }
                }
            }
            catch (Exception e){
                WriteLine("The file could not be read:");
                WriteLine(e.Message);
            }
            return result;
        }
    }
}