using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorContactoTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorContactoTrack 
    {
        public int IdProductorContacto { get; set; }
        public Guid Identificador { get; set; }
        public int? IdProductor { get; set; }
        public int? idTipoContacto { get; set; }
        public string Contacto { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Dispositivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string FechaCreacionUtc { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string FechaModificacionUtc { get; set; }
        public string Transaccion { get; set; }
    }
}      
