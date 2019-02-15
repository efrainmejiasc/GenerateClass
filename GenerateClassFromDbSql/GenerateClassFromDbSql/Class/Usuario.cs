using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Usuario.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Usuario 
    {
        public int IdUsuario { get; set; }
        public int IdGenero { get; set; }
        public int IdPais { get; set; }
        public int IdIdioma { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Foto { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }
        public int IntentosRealizados { get; set; }
        public bool Bloqueado { get; set; }
        public bool Activo { get; set; }
        public bool Visible { get; set; }
        public bool ForzarCambioPassword { get; set; }
        public bool RecuperarContrasenna { get; set; }
        public DateTime RecuperarContrasennaFecha { get; set; }
    }
}      
