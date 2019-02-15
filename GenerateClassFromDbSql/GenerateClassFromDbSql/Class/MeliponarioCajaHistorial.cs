using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCajaHistorial.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCajaHistorial 
    {
        public int IdMeliponarioCajaHistorial { get; set; }
        public string  Identificador { get; set; }
        public int IdMeliponarioCaja { get; set; }
        public int IdProductor { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public bool Actual { get; set; }
        public string Estado { get; set; }
    }
}      
