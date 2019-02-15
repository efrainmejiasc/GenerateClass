using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorAbejasNativasMaterialEntregado.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorAbejasNativasMaterialEntregado 
    {
        public int IdProductorAbejasNativasMaterialEntregado { get; set; }
        public string  Identificador { get; set; }
        public int IdProductor { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroBoleta { get; set; }
        public int IdTipoMaterialEntregado { get; set; }
        public int Cantidad { get; set; }
        public decimal Comentario { get; set; }
        public string Estado { get; set; }
    }
}      
