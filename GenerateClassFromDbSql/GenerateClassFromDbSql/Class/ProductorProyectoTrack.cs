using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorProyectoTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorProyectoTrack 
    {
        public int IdProductorProyecto { get; set; }
        public Guid Identificador { get; set; }
        public int? Idproductor { get; set; }
        public int? IdProyecto { get; set; }
        public bool? EstatusIntegracion { get; set; }
        public DateTime? FechaIntegracion { get; set; }
        public DateTime? Fechasalida { get; set; }
        public string Razonsalida { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Dispositivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string FechaCreacionUtc { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaModificacionUtc { get; set; }
        public string Transaccion { get; set; }
    }
}      
