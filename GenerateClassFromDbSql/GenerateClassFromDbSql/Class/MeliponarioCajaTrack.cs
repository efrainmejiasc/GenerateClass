using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCajaTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCajaTrack 
    {
        public int IdMeliponarioCaja { get; set; }
        public Guid Identificador { get; set; }
        public int? IdMeliponario { get; set; }
        public int? IdEspecieAbeja { get; set; }
        public DateTime? FechaEntregaAlProductor { get; set; }
        public string Comentario { get; set; }
        public int? IdorigenColonia { get; set; }
        public bool? Activa { get; set; }
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
