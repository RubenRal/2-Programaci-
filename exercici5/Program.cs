namespace exercici5;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Entra la primera paraula: ");
        string paraula1 = Console.ReadLine();

        Console.Write("Entra la segona paraula: ");
        string paraula2 = Console.ReadLine();

        Console.Write("Entra la tercera paraula: ");
        string paraula3 = Console.ReadLine();

        // Determinem quina és més llarga
        string mesLlarga = paraula1;

        if (paraula2.Length == paraula1.Length || paraula3.Length == paraula1.Length || paraula3.Length == paraula2.Length)
        {
            Console.WriteLine("Hi ha dues o més paraules de la mateixa longitud màxima.");
            return;
        }
        {
            mesLlarga = paraula2;
        }

        if (paraula2.Length > mesLlarga.Length)
        {
            mesLlarga = paraula2;
        }

        if (paraula3.Length > mesLlarga.Length)
        {
            mesLlarga = paraula3;
        }

        Console.WriteLine("La paraula més llarga és " + mesLlarga);
    }
}
