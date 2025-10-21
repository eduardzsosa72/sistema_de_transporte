namespace sistema_de_transporte.modelos
{
    internal abstract class Vehiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal PrecioDiario { get; set; }
        public bool Disponible { get; set; }
        public int ProveedorId { get; set; } // relación con proveedor

        public abstract string Tipo { get; }

        public virtual string MostrarDatos()
        {
            return $"{Tipo} - {Marca} {Modelo} (${PrecioDiario}/día)";
        }
    }
}
