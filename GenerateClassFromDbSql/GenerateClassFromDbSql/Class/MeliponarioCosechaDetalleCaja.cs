using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCosechaDetalleCaja.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCosechaDetalleCaja 
    {
        public int IdMeliponarioCosechaDetalleCaja { get; set; }
        public string  Identificador { get; set; }
        public int IdMeliponarioCosechaDetalle { get; set; }
        public int IdMeliponarioCaja { get; set; }
        public string Estado { get; set; }
    }
}      
