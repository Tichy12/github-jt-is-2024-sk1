﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadejte výšku písmene Z (minimálně 1): ");
        int vyska;

        // Kontrola platnosti vstupu
        while (!int.TryParse(Console.ReadLine(), out vyska) || vyska < 1)
        {
            Console.Write("Prosím zadejte platnou výšku (minimálně 1): ");
        }

        VykresliZ(vyska);
    }

    static void VykresliZ(int vyska)
    {
        for (int i = 0; i < vyska; i++)
        {
            for (int j = 0; j < vyska; j++)
            {
                if (i == 0 || i == vyska - 1 || j == vyska - i - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
