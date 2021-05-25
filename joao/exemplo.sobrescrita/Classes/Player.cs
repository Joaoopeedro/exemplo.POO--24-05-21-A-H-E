namespace exemplo.sobrescrita.Classes
{
    public class Player
    {
        private float velocidade;

        private float ForcaPulo;

        public virtual string Correr(){
            return "o player correu ";
        }
        public virtual string Pular(){
            return "o player pulou ";
        }

    }
}