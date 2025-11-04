namespace exercici2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el numero:");
        var num = Console.ReadLine();
        int Num = Convert.ToInt32(num);
        if (Num % 2 == 0)
        {
            Console.WriteLine("El número és parell");
        }
        else
        {
            Console.WriteLine("El número és senar");
        }
    }
}
