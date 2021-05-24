using System;

namespace exemplo_POO_A_H_E.Classes
{
    public class Credito : Cartao
    {
        private float Limite = 3000f;

        public void Pagar()
        {
            float Valor = this.valor;
            int vezes ;

            if (Valor > Limite)
            {
                Console.WriteLine("O seu limite nao é suficielte para pagar esse valor!!");


            }
            else
            {

                do
                {


                    Console.WriteLine($"Em quantas vezes deseja parcelar o valor {Valor:C2}? (de 1 a 12 vezes)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes >= 1 && vezes <= 6)
                    {
                        Console.WriteLine($"Você optou em parcelar em {vezes} vez, dessa forma o juros sera de 5% o valor total");
                        Console.WriteLine($"Você pagará {Valor * 1.05:C2} em {vezes} vezez de {(Valor * 1.05) / vezes:C2}");
                    }
                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.WriteLine($"Você optou em parcelar em {vezes} vez, dessa forma o juros sera de 5% o valor total");
                        Console.WriteLine($"Você pagará {Valor * 0.8:C2} em {vezes} vezez de {(Valor * 0.8) /vezes:C2}");

                    }
                    else
                    {
                        Console.WriteLine("Impossivel parcelar nessa quantidade, escolha um numero de vezes entre 1 e 12");
                    }
                } while (vezes < 1 || vezes > 12);

            }
        }
    }
}