using System;

namespace exemplo_POO_A_H_E.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoDeBarras ;

        Random r = new Random();

        public void Registrar(){
            CodigoDeBarras = r.Next(30000000).ToString();

            Console.WriteLine($"Boleto gerado com o codigo {CodigoDeBarras}");
            Console.WriteLine($"Boleto registrado com desconto, o valor agora é de {this.valor * 0.88:C2} ");
        }
    }
}