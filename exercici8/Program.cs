namespace exercici8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entra el número:");
        var n = Console.ReadLine();
        int N = Convert.ToInt16(n);
        if (N <= 20)
        {
            Console.WriteLine("Va al grup Vermell");
        }
        else if (N <= 40)
        {
            Console.WriteLine("Va al grup Blau");
        }
        else if (N <= 60)
        {
            Console.WriteLine("Va al grup Verd");
        }
          else if (N >= 61)
        {
            Console.WriteLine("Va al grup Blanc");
        }
    }
}
