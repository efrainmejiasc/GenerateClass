using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioTrack 
    {
        public int IdMeliponario { get; set; }
        public Guid Identificador { get; set; }
        public int? IdProductor { get; set; }
        public decimal? GPSLatitud { get; set; }
        public decimal? GPSLongitud { get; set; }
        public bool? ValidadoParaRecibirCajasFloraNueva { get; set; }
        public int? IdTipoMeliponario { get; set; }
        public DateTime? FechaCreacionRegistro { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Dispositivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string FechaCreacionUtc { get; set; }
        public DateTime FechModificacion { get; set; }
        public string FechaModificacionUtc { get; set; }
        public string Transaccion { get; set; }
    }
}      
