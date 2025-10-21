using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace sistema_de_transporte.modelos
{
    internal class Pago
    {
        public int Id { get; set; }
        public int RentaId { get; set; }
        public decimal Monto { get; set; }
        public string Metodo { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public DateTime Fecha { get; set; } = DateTime.Now;

        public string ProcesarPago()
        {
            Estado = "Completado";
            return $"Pago de ${Monto} procesado correctamente por {Metodo}.";
        }
    }
}
