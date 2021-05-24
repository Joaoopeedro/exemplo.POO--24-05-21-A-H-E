using System;

namespace exemplo_POO_A_H_E.Classes
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now.Date;

        protected float valor = 2599f;

        public string Cancelar(){
            return "Pagamento Cancelado!!";        }
    }
}