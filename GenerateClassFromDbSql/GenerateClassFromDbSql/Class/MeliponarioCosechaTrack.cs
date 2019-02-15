using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCosechaTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCosechaTrack 
    {
        public int IdMeliponarioCosecha { get; set; }
        public Guid Identificador { get; set; }
        public int? IdMeliponario { get; set; }
        public int? IdUsuarioResponsable { get; set; }
        public decimal? PrecioCompra { get; set; }
        public string Comentario { get; set; }
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
