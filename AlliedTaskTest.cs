using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AlliedTaskAndTest
{
    [TestFixture]
    internal class AlliedTaskTest
    {
        // Test1 (FileToArray)
        [TestCase("A.txt")]
        [TestCase("B.txt")]
        public void FileToArrayTest(string fileName)
        {
            Assert.DoesNotThrow(() => TwoSequencesSort.FileToArray(fileName));
        }

        // Test2.1 (ArrayStringToInt)
        [Test]
        public void ArrayStringToIntTest1()
        {
            string[] myArray = TwoSequencesSort.FileToArray("A.txt");
            Assert.DoesNotThrow(() => TwoSequencesSort.ArrayStringToInt(myArray));
        }

        // Test2.2 (ArrayStringToInt)
        [Test]
        public void ArrayStringToIntTest2()
        {
            string[] myArray = TwoSequencesSort.FileToArray("B.txt");
            Assert.DoesNotThrow(() => TwoSequencesSort.ArrayStringToInt(myArray));
        }

        // Test3.1 (SequencesCombine)
        [Test]
        public void SequencesCombineTest1()
        {
            // Arrange
            int[] arrayA = { 0, 1, 4, 7 };
            int[] arrayB = { 2, 4, 8 };
            int[] arrayC = new int[arrayA.Length + arrayB.Length];
            int[] expectedResult = { 0, 1, 2, 4, 4, 7, 8 };

            // Act
            int[] result = TwoSequencesSort.SequencesCombine(arrayA, arrayB, arrayC);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Test3.2 (SequencesCombine)
        [Test]
        public void SequencesCombineTest2()
        {
            // Arrange
            int[] arrayA = { 1, 3, 5 };
            int[] arrayB = { 1, 4, 6, 8 };
            int[] arrayC = new int[arrayA.Length + arrayB.Length];
            int[] expectedResult = { 1, 1, 3, 4, 5, 6, 8 };

            // Act
            int[] result = TwoSequencesSort.SequencesCombine(arrayA, arrayB, arrayC);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Test3.3 (SequencesCombine)
        [Test]
        public void SequencesCombineTest3()
        {
            // Arrange
            int[] arrayA = { 1, 2, 3, 4 };
            int[] arrayB = { 1, 2, 3, 4 };
            int[] arrayC = new int[arrayA.Length + arrayB.Length];
            int[] expectedResult = { 1, 1, 2, 2, 3, 3, 4, 4 };

            // Act
            int[] result = TwoSequencesSort.SequencesCombine(arrayA, arrayB, arrayC);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
