using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadejte výšku přesýpacích hodin (minimálně 1): ");
        int vyska;

        // Kontrola platnosti vstupu
        while (!int.TryParse(Console.ReadLine(), out vyska) || vyska < 1)
        {
            Console.Write("Prosím zadejte platnou výšku (minimálně 1): ");
        }
        VykresliPresypaciHodiny(vyska);
    }

    static void VykresliPresypaciHodiny(int vyska)
    {
        // Vykreslení horní části přesýpacích hodin (první trojúhelník)
        for (int i = 0; i < vyska; i++)
        {
            // Vypisování mezer pro zarovnání
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            // Vypisování hvězdiček
            for (int j = 0; j < 2 * (vyska - i) - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Vykreslení dolní části přesýpacích hodin (druhý trojúhelník)
        for (int i = 1; i < vyska; i++)
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
