using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCosechaDetalle.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCosechaDetalle 
    {
        public int IdMeliponarioCosechaDetalle { get; set; }
        public string  Identificador { get; set; }
        public int  IdMeliponarioCosecha { get; set; }
        public string Lote { get; set; }
        public int  IdEspecieAbeja { get; set; }
        public double  Alzas { get; set; }
        public double PesoKg { get; set; }
        public string Estado { get; set; }
    }
}      
