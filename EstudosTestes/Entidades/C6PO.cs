using EstudosTestes.Enumeradores;

namespace EstudosTestes.Entidades
{
    public class C6PO : robos
    {
        public C6PO() 
        {
            this.nome = "C6PO";
            this.Modo = EModo.robo;
        }

        public override void Script(int numero)
        {
            this.andar(EDirecaoAndar.Frente, 20);
            this.girar(EGirar.Esquerda, 90);
            this.andar(EDirecaoAndar.Frente, 100);
            this.girar(EGirar.Direita, 19);
        }

        public override void transformar()
        {
            Console.WriteLine(this.nome + " não tem a opção de se transformar!");
        }

    }
}
