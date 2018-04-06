using System;
using static System.Console;

namespace Ch06Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            static int maxValue(int[] intArray) {
                int maxVal = intArray[0];
                for (int i = 1; i < intArray.Length; i++) {
                    if (intArray[i] > maxVal) {
                        maxVal = intArray[i];
                    }
                    return maxVal;
                }
            }

            static void Main(string[] args) {
                int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
                int maxVal = maxValue(myArray);
                WriteLine($"The maximum value in myArray is {maxVal}");
                ReadKey();
            }
        }
    }
}
