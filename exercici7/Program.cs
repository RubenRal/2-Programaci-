namespace exercici7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FC Vilamongat:");
        var r1 = Console.ReadLine();
        int R1 = Convert.ToInt16(r1);

        Console.WriteLine("UE Fontverda: ");
        var r2 = Console.ReadLine();
        int R2 = Convert.ToInt16(r2);

        if (R1 == R2)
        {
            Console.WriteLine($"Partit molt igualat entre els dos rivals que ha acabat en empat {R1} a {R2} tot i els esforços dels dos equips ");
        }
        else if (R1 < R2 )
        {
            Console.WriteLine($"Gran partit del Vilamongat que ha superat a la UE Fontverda per {R1} a {R2} ");            
        }
        else if (R1 > R2)
        {
            Console.WriteLine($"Gran partit de la UE Fontverda que ha superat al FC Vilamongat per {R2} a {R1}");
        }
    }
}
