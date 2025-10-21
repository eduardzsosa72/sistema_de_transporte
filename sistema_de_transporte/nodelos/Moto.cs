using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_transporte.modelos
{
    internal class Moto : Vehiculo
    {
        public int Cilindraje { get; set; }
        public override string Tipo => "Moto";
    }
}
