namespace exemplo.sobrescrita.Classes
{
    public class Zero : Player
    {
        private string sword;

        public override string Pular()
        {
            return "Pulou zika do pantano";
        }

        public override string Correr()
        {
            this.sword = "Espada maneira";
            return base.Correr();
        }
    }
}