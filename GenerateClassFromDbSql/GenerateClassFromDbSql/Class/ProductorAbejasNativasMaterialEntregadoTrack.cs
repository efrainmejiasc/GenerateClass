using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorAbejasNativasMaterialEntregadoTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorAbejasNativasMaterialEntregadoTrack 
    {
        public int IdProductorAbejasNativasMaterialEntregado { get; set; }
        public Guid Identificador { get; set; }
        public int? IdProductor { get; set; }
        public DateTime? Fecha { get; set; }
        public int? NumeroBoleta { get; set; }
        public int? IdTipoMaterialEntregado { get; set; }
        public int? Cantidad { get; set; }
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
