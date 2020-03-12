using System;

namespace Prototype_deep
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal am = new Animal() { Nombre = "Mauricio", Patas = 4 };
            am.Rasgos = new Detalles();
            am.Rasgos.Color = "Negro";
            am.Rasgos.Raza = "Rialengo";

            Animal amclon = am.Clone() as Animal;
            amclon.Rasgos.Color = "Marron";
            amclon.Nombre = "Papolo";

            Console.WriteLine("Color del animal original: " + am.Rasgos.Color);
            Console.WriteLine("Color del animal clonado: " + amclon.Rasgos.Color);
            Console.WriteLine("Nombre del animal original: " + am.Nombre);
            Console.WriteLine("Nombre del animal clonado: " + amclon.Nombre);
            Console.ReadKey();
        }
    }
}
