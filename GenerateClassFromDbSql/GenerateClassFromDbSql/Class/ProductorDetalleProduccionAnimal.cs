using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorDetalleProduccionAnimal.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorDetalleProduccionAnimal 
    {
        public int IdProductorDetalleProduccionAnimal { get; set; }
        public string  Identificador { get; set; }
        public int IdProductor { get; set; }
        public int IdAnimales { get; set; }
        public string Detalles { get; set; }
        public decimal Cantidad { get; set; }
        public string Estado { get; set; }
    }
}      
