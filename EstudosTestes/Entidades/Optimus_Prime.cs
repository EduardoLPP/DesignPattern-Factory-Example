using EstudosTestes.Enumeradores;

namespace EstudosTestes.Entidades
{
    public class Optimus_Prime : robos
    {
        public Optimus_Prime()
        {
            this.nome = "Optimus_Prime";
            this.Modo = Enumeradores.EModo.veiculo;
        }

        public override void Script(int numero)
        {
            switch (numero)
            {
                case 1:
                    if (this.Modo == EModo.veiculo)
                        this.transformar();
                    this.girar(EGirar.Esquerda, 25);
                    this.andar(EDirecaoAndar.Esquerda, 2);
                    this.andar(EDirecaoAndar.Frente, 10);
                    break;
            }
        }

        public override void transformar()
        {
            this.Modo = (this.Modo == EModo.veiculo ? EModo.robo : EModo.veiculo);

            Console.WriteLine(this.nome + " está em modo " + this.Modo.ToString());
        }
    }
}
