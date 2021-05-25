using System;
using exemplo.sobrecarga.Classes;

namespace exemplo.sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (int i = 0; i < f.lista.Length; i++)
            {
                Console.WriteLine("Digite um item para a lista: ");
                f.lista[i] = Console.ReadLine();
            }



            Console.WriteLine("\nMostrar sem argumentos");
            f.Mostrar();

            Console.WriteLine("\nMostrar sem argumentos int");
            f.Mostrar(2);

            Console.WriteLine("\nMostrar sem argumentos string");
            f.Mostrar("manga");
        }
    }
}
