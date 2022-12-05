using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Day4
{
    public class Compare
    {
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

        public int internalGroups(string file, int size){
            //int[] groups = new int[size];
            int elfCounter = 0;
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var sizes = line.Split(new char[] {'-', ','});
                        int a = Int32.Parse(sizes[0]);
                        int b = Int32.Parse(sizes[1]);
                        int c = Int32.Parse(sizes[2]);
                        int d = Int32.Parse(sizes[3]);

                        if (a >= c && b <= d || a <= c && b >= d || a == c && b == d){
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

        public int overlapping(string file, int size){
            //int[] groups = new int[size];
            int elfCounter = 0;
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var sizes = line.Split(new char[] {'-', ','});
                        int a = Int32.Parse(sizes[0]);
                        int b = Int32.Parse(sizes[1]);
                        int c = Int32.Parse(sizes[2]);
                        int d = Int32.Parse(sizes[3]);

                        List<int> range1 = new List<int>();
                        List<int> range2 = new List<int>();
                        for (int i = a; i <= b; i++){
                            range1.Add(i);
                        }
                        for (int i = c; i <= d; i++){
                            range2.Add(i);
                        }
                        for (int i = 0; i < range1.Count; i++){
                            if (range2.Contains(range1[i])){
                                elfCounter++;
                                break;
                            }
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
    }
}