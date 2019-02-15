using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorInventarioEspecies.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorInventarioEspecies 
    {
        public int IdProductorInventarioEspecies { get; set; }
        public string Identificador { get; set; }
        public int IdProductor { get; set; }
        public int IdEspecieAbeja { get; set; }
        public int CantidadEnTronco { get; set; }
        public int CantidadEnNidoArtificial { get; set; }
        public int CantidadEnCajaRustica { get; set; }
        public int CantidadEnCajaTecnificada { get; set; }
        public string Estado { get; set; }
    }
}      
