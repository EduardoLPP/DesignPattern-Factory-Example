using EstudosTestes.Enumeradores;

namespace EstudosTestes.Entidades
{
    public class Bumblebee : robos
    {
        public Bumblebee()
        {
            this.nome = "Bumblebee";
            this.Modo = Enumeradores.EModo.veiculo;
        }

        public override void Script(int numero)
        {
            switch (numero)
            {
                case 1:
                    if (this.Modo == EModo.veiculo)
                        this.transformar();
                    this.girar(EGirar.Direita, 1);
                    this.andar(EDirecaoAndar.Direita, 2);
                    this.andar(EDirecaoAndar.Frente, 1);
                    break;
                case 2:
                    if (this.Modo == EModo.veiculo)
                        this.transformar();
                    this.andar(EDirecaoAndar.Frente, 15);
                    this.andar(EDirecaoAndar.Direita, 4);
                    this.girar(EGirar.Direita, 180);
                    this.andar(EDirecaoAndar.Frente, 2);
                    break;
                case 3:
                    if (this.Modo == EModo.veiculo)
                        this.transformar();
                    Console.WriteLine(this.nome + " está sambando ");
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
