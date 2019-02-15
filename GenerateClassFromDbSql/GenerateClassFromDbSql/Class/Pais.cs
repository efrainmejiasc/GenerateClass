using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Pais.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Pais 
    {
        public int IdPais { get; set; }
        public string Nombre { get; set; }
        public char ISO3 { get; set; }
        public int IdMonedaOficial { get; set; }
        public char CodigoPaisTelefono { get; set; }
    }
}      
