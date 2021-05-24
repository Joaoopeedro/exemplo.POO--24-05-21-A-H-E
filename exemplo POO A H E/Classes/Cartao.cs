
using System;

namespace exemplo_POO_A_H_E.Classes
{
    public abstract class Cartao :Pagamento
    {
        public string Bandeira; 
        public string Numero;
        public string Titular;
        public string Cvv;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira do cartão");
            Bandeira = Console.ReadLine();
            Console.WriteLine("Digite a numero do cartão");
            Numero = Console.ReadLine();
            Console.WriteLine("Digite a titular do cartão");
            Titular = Console.ReadLine();
            Console.WriteLine("Digite a Cvv do cartão");
            Cvv = Console.ReadLine();

            return $"Cartao de numero {Numero} está salvo ";
        }
    }
}