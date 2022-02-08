using EstudosTestes.Entidades;
using EstudosTestes.Enumeradores;

namespace EstudosTestes
{
    public static class Factory
    {
        public static robos Criar(ERobos robo)
        {
            return Criar(robo.ToString());   
        }
        
        public static robos Criar(String robo)
        {
            switch (robo)
            {
                default:
                case "C6PO":
                    return new C6PO();
                case "Optimus_Prime":
                    return new Optimus_Prime();
                case "Bumblebee":
                    return new Bumblebee();
            }
        }
    }
}
    