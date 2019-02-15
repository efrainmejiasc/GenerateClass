using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a TipoEventoIdioma.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class TipoEventoIdioma 
    {
        public int IdTipoEvento { get; set; }
        public int IdIdioma { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}      
