﻿using System;

class Triangle
{
    public static void Main()
    {
        Console.Write("Input n: ");

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int row = 1; row <= n; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write("{0} ", column);
            }
            Console.WriteLine();
        }
    }
}