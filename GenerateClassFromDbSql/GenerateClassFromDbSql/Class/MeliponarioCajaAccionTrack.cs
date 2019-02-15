using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCajaAccionTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCajaAccionTrack 
    {
        public int IdMeliponarioCajaAccion { get; set; }
        public Guid Identificador { get; set; }
        public int? IdMelponarioCaja { get; set; }
        public int? IdTipoAccionMelponario { get; set; }
        public int? IdOrigenColonia { get; set; }
        public int? IdUsuarioResponsable { get; set; }
        public DateTime? FechaAccion { get; set; }
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
