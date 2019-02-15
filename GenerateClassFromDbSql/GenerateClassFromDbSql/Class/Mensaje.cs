using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Mensaje.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Mensaje 
    {
        public int IdMensaje { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuarioEnviador { get; set; }
        public int IdTipoMensaje { get; set; }
        public int IdEstadoMensaje { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime? FechaDeEnvio { get; set; }
    }
}      
