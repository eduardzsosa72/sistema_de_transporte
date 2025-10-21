using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_transporte.modelos
{
    internal class Auto : Vehiculo
    {
        public int NumeroPuertas { get; set; }
        public override string Tipo => "Auto";
    }
}

