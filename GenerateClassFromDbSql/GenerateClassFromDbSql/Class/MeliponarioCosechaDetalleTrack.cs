using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCosechaDetalleTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCosechaDetalleTrack 
    {
        public int IdMeliponarioCosechaDetalle { get; set; }
        public Guid Identificador { get; set; }
        public int? IdMeliponarioCosecha { get; set; }
        public string Lote { get; set; }
        public int? IdEspecieAbeja { get; set; }
        public decimal? Alzas { get; set; }
        public decimal? PesoKg { get; set; }
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
