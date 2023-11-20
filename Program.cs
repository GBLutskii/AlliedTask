using AlliedTaskAndTest;

namespace Allied_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileNameA = "A.txt";
            string fileNameB = "B.txt";

            string[] textA = TwoSequencesSort.FileToArray(fileNameA);
            string[] textB = TwoSequencesSort.FileToArray(fileNameB);

            int[] arrayA = TwoSequencesSort.ArrayStringToInt(textA);
            int[] arrayB = TwoSequencesSort.ArrayStringToInt(textB);

            int[] arrayC = TwoSequencesSort.ResultArray(arrayA, arrayB);

            TwoSequencesSort.SequencesCombine(arrayA, arrayB, arrayC);

            string[] textC = TwoSequencesSort.ArrayIntToString(arrayC);

            TwoSequencesSort.FileWriting(textC);
        }
    }
}