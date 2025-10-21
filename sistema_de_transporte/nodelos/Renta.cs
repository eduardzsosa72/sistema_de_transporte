using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace sistema_de_transporte.modelos
{
    internal class Renta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Costo { get; set; }
        public string Estado { get; set; } = "Pendiente";

        public decimal CalcularCosto(decimal precio)
        {
            int dias = (FechaFin - FechaInicio).Days;
            if (dias <= 0) dias = 1;
            return precio * dias;
        }
    }
}
