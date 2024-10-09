using System;

class Program {
    static void Main() {
        
        string again = "a";

        while (again=="a") {


        Console.Clear();
        Console.WriteLine("****************************");
        Console.WriteLine("******Výpis řady čísel******");
        Console.WriteLine("****************************");
        Console.WriteLine();

        // Vstup hodnot do programu špatně 
/*         Console.WriteLine();
        Console.Write("Zadejte první číslo řady: ");
        int first = int.Parse(Console.ReadLine()); */

        //Vstup hodnot do programu spávně

                Console.WriteLine("Zadejte první číslo řady (celé číslo)");
        int first;
        while (!int.TryParse(Console.ReadLine(), out first)) {
            Console.WriteLine("Nezadlai jste celé číslo. Zadejte prní číslo řady znovu");
        }

        Console.WriteLine("Zadejte poslendí číslo řady (celé číslo)");
        int last;
        while (!int.TryParse(Console.ReadLine(), out last)) {
            Console.WriteLine("Nezadlai jste celé číslo. Zadejte poslední číslo řady znovu");
        }

        Console.WriteLine("Zadejte diferenci (celé číslo)");
        int step;
        while (!int.TryParse(Console.ReadLine(), out step)) {
            Console.WriteLine("Nezadlai jste celé číslo. Zadejte prní číslo řady znovu");
        }


        //Výpis řady
        int current = first;
        while(current <= last) {
            Console.WriteLine(current);
            current = current + step; // Ruční přičtění diference

        }


        Console.WriteLine();
        Console.WriteLine("Zadali jste tyto hodnoty");
        Console.WriteLine("První číslo řady: {0}", first); 
        Console.WriteLine("Poslední číslo řady: {0}", last);
        Console.WriteLine("Diference: {0}", step);  

        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu A");
        again = Console.ReadLine();


    }



    }
}


// toto je jednořádkový komentář

/* toto je
víceřádkový
komentář */

