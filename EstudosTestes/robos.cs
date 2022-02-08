using EstudosTestes.Enumeradores;

namespace EstudosTestes
{
    public abstract class robos
    {
        protected String nome { get; set; }
        protected EModo Modo { get; set; }

        public void andar(EDirecaoAndar direcao, int passos)
        {
            Console.WriteLine("O robo " + this.nome + " está andando " + direcao.ToString() + " " + passos);
        }

        public void girar(EGirar movimento, int graus)
        {
            Console.WriteLine("O robo " + this.nome + " está girando para " + movimento.ToString() + " " + graus);
        }

        public abstract void transformar();
        public abstract void Script(int numero);
    }
}
