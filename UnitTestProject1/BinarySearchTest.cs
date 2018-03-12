using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication;

namespace BinarySearchTests
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void TestFiveNumbers()

        {
            //Тестирование поиска с пятью числами

            int[] fiveNumbers = new[] { -5, -4, -3, 0 , 100};

            var result = Program.BinarySearch(fiveNumbers, -5);

            Assert.AreEqual(expected: 0, actual: result);
        }

        [TestMethod]
        public void TestNegativeNumbers()

        {
            //Тестирование поиска в отрицательных числах

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            var result = Program.BinarySearch(negativeNumbers, -3);

            Assert.AreEqual(expected: 2, actual: result);
        }

        [TestMethod]
        public void TestNonExistentElement()

        {
            //Тестирование поиска отсутствующего элемента

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            var result = Program.BinarySearch(negativeNumbers, -1);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestRepitingElement()

        {
            //Тестирование поиска с повторяющимися элементами

            int[] negativeNumbers = new[] { -5, -4, -4, -4, -3, -1 };

            var result = Program.BinarySearch(negativeNumbers, -4);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestEmptyArray()

        {
            //Тестирование поиска пустого массива

            int[] noNumbers = new int[] { };

            var result = Program.BinarySearch(noNumbers, -4);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestBigArray()

        {
            //Тестирование поиска массива из 100001 чисел
            Random rnd = new Random();

            int[] aLotOfNumbers = new int[100001];

            for (int i = 0; i<aLotOfNumbers.Length; i++)
            aLotOfNumbers[i] = i+1;

            var result = Program.BinarySearch(aLotOfNumbers, 123);

            Assert.AreEqual(122, result);
        }

    }
}
