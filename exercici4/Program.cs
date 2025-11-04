namespace exercici4;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Entra el número: ");
        string numero = Console.ReadLine();

        if (numero.Length != 3 || !int.TryParse(numero, out _))
        {
            Console.WriteLine("Si us plau, entra un número de tres xifres.");
        }
        else
        {
            if (numero[0] == numero[2])
            {
                Console.WriteLine("El número és capicua");
            }
            else
            {
                Console.WriteLine("El número no és capicua");
            }
        }
    }
}
