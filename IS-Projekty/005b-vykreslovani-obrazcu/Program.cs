﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadejte výšku kosočtverce (minimálně 1): ");
        int vyska;

        // Kontrola platnosti vstupu
        while (!int.TryParse(Console.ReadLine(), out vyska) || vyska < 1)
        {
            Console.Write("Prosím zadejte platnou výšku (minimálně 1): ");
        }

        VykresliKosocverec(vyska);
    }

    static void VykresliKosocverec(int vyska)
    {
        // Vykreslení horní části kosočtverce (první trojúhelník)
        for (int i = 0; i < vyska; i++)
        {
            // Vypisování mezer pro zarovnání
            for (int j = 0; j < vyska - i - 1; j++)
            {
                Console.Write(" ");
            }

            // Vypisování hvězdiček
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Vykreslení dolní části kosočtverce (druhý trojúhelník)
        for (int i = vyska - 2; i >= 0; i--)
        {
            // Vypisování mezer pro zarovnání
            for (int j = 0; j < vyska - i - 1; j++)
            {
                Console.Write(" ");
            }

            // Vypisování hvězdiček
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
