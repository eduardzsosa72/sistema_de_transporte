namespace sistema_de_transporte.modelos
{
    internal class Cliente : Usuario
    {
        public string DUI { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {
            Rol = "Cliente";
        }

        public override string MostrarDatos()
        {
            return $"{Nombre} (Cliente) - {Correo}";
        }
    }
}
