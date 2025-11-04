namespace exercici10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entra el numero 1:");
        var a = Console.ReadLine();
        double aa = Convert.ToDouble(a);
        Console.WriteLine("Entra el numero 2:");
        var b = Console.ReadLine();
        double bb = Convert.ToDouble(b);
        Console.WriteLine("Entra el numero 3:");
        var c = Console.ReadLine();
        double cc = Convert.ToDouble(c);
        if (aa < 0)
        {
            aa = aa * (-1);
        }


        double ba = bb - aa;
        double ca = cc - aa; 
        
        if (ba < 0 )
        {
            ba = ba * (-1);
        }
        if (ca < 0)
        {
            ca = ca * (-1);
        }
        
        if (ca == ba)
        {
            Console.WriteLine("Els dos numeros estan igual de aprop");
        }
        else if (ba < ca){
            Console.WriteLine($"El numero més proper a {aa} és {bb}");
        }
        else{
            Console.WriteLine($"El numero més proper a {aa} és {cc}");
        }
        
    }
}
