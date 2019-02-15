using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Recurso.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Recurso 
    {
        public int IdRecurso { get; set; }
        public int? IdRecursoPadre { get; set; }
        public int IdModulo { get; set; }
        public bool TieneHijos { get; set; }
        public string UrlRecurso { get; set; }
        public string UrlImagenOpcionMenu { get; set; }
        public int Nivel { get; set; }
        public bool SuperAdministrador { get; set; }
        public int IdTipoRecurso { get; set; }
    }
}      
