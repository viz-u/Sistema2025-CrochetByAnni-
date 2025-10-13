namespace Sistema2025.Utils
{
    public static class SesionActual
    {
        public static int UsuarioId { get; set; }
        public static string Nombre { get; set; } = string.Empty;
        public static string Usuario { get; set; } = string.Empty;
        public static string Rol { get; set; } = string.Empty;
        public static bool Activo { get; set; }

        public static void CerrarSesion()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Usuario = string.Empty;
            Rol = string.Empty;
            Activo = false;
        }
    }
}
