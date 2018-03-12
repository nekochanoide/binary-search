using System;

namespace ConsoleApplication

{
    public class Program
    {
        public static int BinarySearch(int[] array, int value)
        {
            if (array.Length == 0)
                return -1;

            int left = 0, right = array.Length - 1;
            int selectedNumber = right / 2;

            for (int i = 0; i < array.Length; i++)
            {
                if (value != array[selectedNumber])
                {
                    if (value < array[selectedNumber])
                    {
                        if (selectedNumber == 0)
                            return -1;

                        right = selectedNumber - 1;
                        selectedNumber = right / 2;
                    }
                    else
                    {
                        if (selectedNumber == 0)
                            return selectedNumber + 1;
                        if (selectedNumber == array.Length - 1)
                            return -1;

                        left = selectedNumber + 1;
                        selectedNumber = (right + left) / 2;
                    }
                }
                else break;
            }
            return selectedNumber;
            //код поиска значения value в массиве arrays
        }

        public static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}