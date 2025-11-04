namespace exercici3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriu el teu nom d'usuari:");
        var Nu = Console.ReadLine();
        if (Nu == "administrador")
        {
            Console.WriteLine("Benvingut al sistema.");
         }
        else
        {
            Console.WriteLine("Introdueix la teva contrasenya:");
            Console.ReadLine();
            Console.WriteLine("Benvingut al sistema.");   
        }
    }
}
