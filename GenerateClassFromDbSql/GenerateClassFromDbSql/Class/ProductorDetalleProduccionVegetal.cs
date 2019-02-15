using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorDetalleProduccionVegetal.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorDetalleProduccionVegetal 
    {
        public int IdProductorDetalleProduccionVegetal { get; set; }
        public string  Identificador { get; set; }
        public int IdProductor { get; set; }
        public int IdCategoriaUsoSuelo { get; set; }
        public string Detalles { get; set; }
        public decimal Superficie { get; set; }
        public string Estado { get; set; }
    }
}      
