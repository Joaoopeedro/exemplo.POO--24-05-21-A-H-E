using System;
using exemplo.sobrescrita.Classes;
namespace exemplo.sobrescrita
{
    class Program
    {
        static void Main(string[] args)
        {
            Megamen m = new Megamen();
            Zero z = new Zero();

            Console.WriteLine("Megamen: ");
            Console.WriteLine( m.Correr());
            Console.WriteLine( m.Pular());

            Console.WriteLine("\nZero: " );
            Console.WriteLine( z.Correr());
            Console.WriteLine( z.Pular());

            
        }
    }
}
