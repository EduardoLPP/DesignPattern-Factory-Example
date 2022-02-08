using EstudosTestes;
using EstudosTestes.Enumeradores;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ERobos> Robos = new List<ERobos> { ERobos.C6PO, ERobos.Bumblebee, ERobos.Optimus_Prime };


            robos robo1;

            Robos.ForEach(delegate (ERobos r)
            {
            robo1 = Factory.Criar(r);
            robo1.Script(0);
            robo1.transformar();
            robo1.Script(1);
            robo1.Script(2);
            robo1.Script(3);
            robo1.transformar();
            Console.WriteLine();
            });

        Console.ReadKey();


    }
}
  
}