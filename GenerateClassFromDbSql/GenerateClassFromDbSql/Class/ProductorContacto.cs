using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorContacto.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorContacto 
    {
        public int IdProductorContacto { get; set; }
        public string Identificador { get; set; }
        public int IdProductor { get; set; }
        public int IdTipoContacto { get; set; }
        public string Contacto { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
    }
}      
