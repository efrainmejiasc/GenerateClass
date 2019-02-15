using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Moneda.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Moneda 
    {
        public int IdMoneda { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Simbolo { get; set; }
        public string ISO4217 { get; set; }
    }
}      
