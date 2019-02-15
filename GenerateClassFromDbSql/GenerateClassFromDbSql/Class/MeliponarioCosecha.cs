using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCosecha.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCosecha 
    {
        public int IdMeliponarioCosecha { get; set; }
        public string Identificador { get; set; }
        public int IdMeliponario { get; set; }
        public int IdUsuarioResponsable { get; set; }
        public decimal PrecioCompra { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }
    }
}      
