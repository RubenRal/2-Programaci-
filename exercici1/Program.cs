using System.Globalization;

namespace exercici1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix la nota:");
        var num = Console.ReadLine();
        int Num = Convert.ToInt32(num);

        if (Num <= 4.9)
        {
            Console.WriteLine("Suspés");
        }
        else
        {
            Console.WriteLine("Aprovat");
        }

    }
}
