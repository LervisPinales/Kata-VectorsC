using System;

namespace KataMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X1: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1: ");
            int Y = int.Parse(Console.ReadLine());

            KataVA.Vector OpeA = new KataVA.Vector(x, Y);
            
            Console.WriteLine("Enter X2: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2: ");
            int B = int.Parse(Console.ReadLine());

            KataVA.Vector OpeB = new KataVA.Vector(A, B);

            Console.WriteLine($"The Magnitud A is: {OpeA.Magnitude()}");
            Console.WriteLine($"The Magnitud B is: {OpeB.Magnitude()}");
            
        }
    }
}
