using System;

namespace MultiplicationMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numberArray = { 1, 2, 3, 4, 5, 6 }; // insert multiplication numbers here
            DasMultiplier(numberArray);
        }
        public static void DasMultiplier(int[] arr)
        {
            // get first digit
            for (int firstIndex = 0; firstIndex < arr.Length; firstIndex++)
            {
                int value1 = arr[firstIndex];

                // get second digit
                for (int secondIndex = 0; secondIndex < arr.Length; secondIndex++)
                {
                    int value2 = arr[secondIndex];
                    int result = value1*value2;
                    
                    // check first digit can be used -> print it out
                    for (int i = 0; i <= secondIndex; i++) {
                        if (arr[firstIndex] == arr[i]) {
                            Console.WriteLine(value1 + " * " + value2 + " = " + result);
                        }
                    }
                }
            }
        }
    }
}
