﻿using System;

namespace ArrayGrower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number (negative number quits):");  // instructions

            int givenNumber = 0;                          // needed to starts the while loop
            string[] numbers = new string[0];             // create an Array with 0-slots
            int entries = 0;                              // calculate number of user entries 

            while (givenNumber > -1)                      // while user number is 0 or positive -> loop continues
            {                      
                entries++;                                // count the entries
                string userInput = Console.ReadLine();    // get user input
                givenNumber = int.Parse(userInput);       // convert user input (string) to integer
                if (givenNumber < 0)                      // avoid storing negative number in Array
                {
                    break;
                }
                Array.Resize(ref numbers, entries);       // resize Array to be as big as number of entries
                numbers[entries - 1] = userInput;         // assign user input to Array using entries (-1 to get correct slot)
            }
            Console.WriteLine(string.Join(',', numbers)); // join the arrays together and print 'em out
        }
    }
}