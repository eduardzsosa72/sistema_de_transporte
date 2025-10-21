namespace sistema_de_transporte.modelos
{
    internal class Administrador : Usuario
    {
        public string Cargo { get; set; }

        public Administrador()
        {
            Rol = "Administrador";
        }

        public override string MostrarDatos()
        {
            return $"{Nombre} (Admin - {Cargo})";
        }
    }
}
