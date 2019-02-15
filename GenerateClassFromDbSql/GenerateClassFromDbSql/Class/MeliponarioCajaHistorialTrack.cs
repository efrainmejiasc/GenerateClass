using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCajaHistorialTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCajaHistorialTrack 
    {
        public int IdMeliponarioCajaHistorial { get; set; }
        public Guid Identificador { get; set; }
        public int? IdMelponarioCaja { get; set; }
        public int? IdProductor { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public bool? Actual { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Dispositivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string FechaCreacionUtc { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string FechamodificacionUtc { get; set; }
        public string Transaccion { get; set; }
    }
}      
