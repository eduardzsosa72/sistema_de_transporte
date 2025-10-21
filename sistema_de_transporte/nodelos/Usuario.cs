namespace sistema_de_transporte.modelos
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; } // Cliente / Proveedor / Administrador

        public Usuario() { }

        public Usuario(int id, string nombre, string correo, string contraseña, string rol)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Contraseña = contraseña;
            Rol = rol;
        }

        public virtual string MostrarDatos()
        {
            return $"{Nombre} ({Rol}) - {Correo}";
        }
    }
}
