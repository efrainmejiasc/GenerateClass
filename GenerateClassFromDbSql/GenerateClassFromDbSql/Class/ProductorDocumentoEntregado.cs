using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorDocumentoEntregado.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorDocumentoEntregado 
    {
        public int IdProductorDocumentoEntregado { get; set; }
        public Guid Identificador { get; set; }
        public int? IdProductor { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
    }
}      
