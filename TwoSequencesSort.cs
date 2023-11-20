using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlliedTaskAndTest
{
    internal class TwoSequencesSort
    {
        // creation array of strings from file
        public static string[] FileToArray(string fileName)
        {
            string[] arrayString = File.ReadAllLines(fileName);
            return arrayString;
        }

        // converting array of strings to array of integers
        public static int[] ArrayStringToInt(string[] arrayString)
        {
            int[] arrayInt = Array.ConvertAll(arrayString, int.Parse);
            return arrayInt;
        }

        // creation an empty array for combining data of 2 other arrays
        public static int[] ResultArray(int[] arrayA, int[] arrayB)
        {
            int[] arrayC = new int[arrayA.Length + arrayB.Length];
            return arrayC;
        }

        // main algorithm of sorting (comments inside)
        public static int[] SequencesCombine(int[] arrayA, int[] arrayB, int[] arrayC, int indexA = 0, int indexB = 0, int indexC = 0)
        {
            // algorithm for adding sorted values to arrayC from 2 different arrays simultaneously (not sufficient in some cases)
            while (indexA < arrayA.Length && indexB < arrayB.Length)
            {
                if (arrayA[indexA] <= arrayB[indexB])
                {
                    arrayC[indexC] = arrayA[indexA];
                    indexA++;
                }
                else
                {
                    arrayC[indexC] = arrayB[indexB];
                    indexB++;
                }
                indexC++;
            }

            // completing arrayC with remaining values of arrayA (case: arrayA contains bigger values)
            while (indexA < arrayA.Length)
            {
                arrayC[indexC] = arrayA[indexA];
                indexA++;
                indexC++;
            }

            // completing arrayC with remaining values of arrayB (case: ArrayB contains bigger values)
            while (indexB < arrayB.Length)
            {
                arrayC[indexC] = arrayB[indexB];
                indexB++;
                indexC++;
            }

            return arrayC;
        }

        // converting final array of ints to array of strings
        public static string[] ArrayIntToString(int[] arrayC)
        {
            string[] textC = Array.ConvertAll(arrayC, num => num.ToString());
            return textC;
        }

        // writing an array to file (with file creation if needed)
        public static void FileWriting(string[] textC, string fileName = "C.txt")
        {
            File.WriteAllLines(fileName, textC);
            Console.WriteLine($"Success! \nCheck your file {fileName} in according directory!");
        }
    }
}
