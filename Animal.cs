using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_deep
{
    class Animal : ICloneable
    {
        public int Patas { get; set; }
        public string Nombre { get; set; }

        public Detalles Rasgos { get; set; }

        public object Clone()
        {
            Animal clonado = this.MemberwiseClone() as Animal;
            Detalles detalles = new Detalles();
            detalles.Color = this.Rasgos.Color;
            detalles.Raza = this.Rasgos.Raza;
            clonado.Rasgos = detalles;
            return clonado;
        }
    }

    public class Detalles
    {
        public string Color { get; set; }
        public string Raza { get; set; }
    }
}
