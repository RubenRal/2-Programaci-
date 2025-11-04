using System.Formats.Asn1;

namespace exercici6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entra el primer nom: ");
        var n1 = Console.ReadLine();
        Console.WriteLine($"Entra l'edat d'en {n1} :");
        var e1 = Console.ReadLine();
        int E1 = Convert.ToInt16(e1);
        Console.WriteLine("Entra el segon nom: ");
        var n2 = Console.ReadLine();
        Console.WriteLine($"Entra l'edat d'en {n2} :");
        var e2 = Console.ReadLine();
        int E2 = Convert.ToInt16(e2);
        if (E1 == E2)
        {
            Console.WriteLine("Els dos tenen la mateixa edat");
        }
        else if (E1 < E2)
        {
            Console.WriteLine($"En {n1} és més jove que en {n2}");

        }
        else
        {
            Console.WriteLine($"En {n2} és més jove que en {n1}");
        }

     }
}
