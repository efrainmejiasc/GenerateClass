using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Meliponario.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Meliponario 
    {
        public int IdMeliponario { get; set; }
        public string Identificador { get; set; }
        public int IdProductor { get; set; }
        public decimal GPSLatitud { get; set; }
        public decimal GPSLongitud { get; set; }
        public bool ValidadoParaRecibirCajasFloraNueva { get; set; }
        public int IdTipoMeliponario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
    }
}      
