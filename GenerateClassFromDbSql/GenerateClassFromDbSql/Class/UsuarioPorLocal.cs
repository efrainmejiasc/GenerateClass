using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a UsuarioPorLocal.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class UsuarioPorLocal 
    {
        public int IdUsuario { get; set; }
        public int IdLocal { get; set; }
        public bool AccesadoPorUltimaVez { get; set; }
        public int IdPerfil { get; set; }
        public bool? Visible { get; set; }
    }
}      
