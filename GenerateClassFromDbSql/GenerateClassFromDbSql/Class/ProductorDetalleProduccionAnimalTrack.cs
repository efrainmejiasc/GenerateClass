using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorDetalleProduccionAnimalTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorDetalleProduccionAnimalTrack 
    {
        public int IdProductorDetalleProduccionAnimal { get; set; }
        public Guid Identificador { get; set; }
        public int? IdProductor { get; set; }
        public int? IdAnimales { get; set; }
        public string Detalles { get; set; }
        public decimal? Cantidad { get; set; }
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
