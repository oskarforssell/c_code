﻿using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8;

            switch (num)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:                 // in this case, if value 3 it moves from case 3 to case 4
                case 4:
                    Console.WriteLine("3 or 4");
                    break;
                default:
                    Console.WriteLine("something");
                    break;

            }
        }
    }
}
