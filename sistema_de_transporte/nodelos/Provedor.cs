namespace sistema_de_transporte.modelos
{
    internal class Proveedor : Usuario
    {
        public string Empresa { get; set; }
        public string Telefono { get; set; }

        public Proveedor()
        {
            Rol = "Proveedor";
        }

        public override string MostrarDatos()
        {
            return $"{Nombre} (Proveedor - {Empresa})";
        }
    }
}
