using System;

namespace exemplo_POO_A_H_E.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 600f;

        public void Pagar(){
            float Valor = this.valor;

            if (Valor > Saldo)
            {
                Console.WriteLine("Seu saldo é insuficiente!");
            }else
            {
                Console.WriteLine($"O valor de {valor:C2} foi pago com sucesso!");
            }
        }
    }
}