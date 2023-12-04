using System.Runtime.CompilerServices;

namespace Allied_Task_2._0
{
    internal class Program
    {
        // method for testing current string can be converted to integer
        static void StringToIntTest (string myString, string myFile)
        {
            try
            {
                Convert.ToInt32(myString);
            }
            catch
            {
                Console.WriteLine($"Some of strings in {myFile} were not in a correct format!");
                Environment.Exit(0);
            }
        }

        // the algorithm of sorting
        static void TwoSequencesSort (string fileA, string fileB, string fileC)
        {
            // checking an existance of required files
            if (File.Exists(fileA) == false)
            {
                Console.WriteLine($"File '{fileA}' is not found!");
                Environment.Exit(0);
            }

            if (File.Exists(fileB) == false)
            {
                Console.WriteLine($"File '{fileB}' is not found!");
                Environment.Exit(0);
            }

            // creating Stream objects
            using (StreamReader myReaderA = new StreamReader(fileA))
            using (StreamReader myReaderB = new StreamReader(fileB))
            using (StreamWriter myWriterC = new StreamWriter(fileC))
            {
                // initialization and declaring strings as first strings of each file invoking StreamReader.ReadLine() method
                string myStringA = myReaderA.ReadLine();
                string myStringB = myReaderB.ReadLine();
                // algorithm for adding sorted values to result file from 2 different given files (not sufficient in some cases)
                while (myStringA != null && myStringB != null)
                {
                    StringToIntTest(myStringA, fileA);
                    StringToIntTest(myStringB, fileB);

                    if (Convert.ToInt32(myStringA) <= Convert.ToInt32(myStringB))
                    {
                        myWriterC.WriteLine(myStringA);
                        myStringA = myReaderA.ReadLine();
                    }
                    else
                    {
                        myWriterC.WriteLine(myStringB);
                        myStringB = myReaderB.ReadLine();
                    }
                }
                // completing result file with remaining values of the first given file (case: the first file contains bigger values)
                while (myStringA != null)
                {
                    StringToIntTest(myStringA, fileA);
                    myWriterC.WriteLine(myStringA);
                    myStringA = myReaderA.ReadLine();
                }
                // completing result file with remaining values of the second given file (case: the second file contains bigger values)
                while (myStringB != null)
                {
                    StringToIntTest(myStringB, fileB);
                    myWriterC.WriteLine(myStringB);
                    myStringB = myReaderB.ReadLine();
                }
            }
        }
        static void Main(string[] args)
        {
            string fileA = "A.txt";
            string fileB = "B.txt";           
            string fileC = "C.txt";

            TwoSequencesSort(fileA, fileB, fileC);
        }
    }
}