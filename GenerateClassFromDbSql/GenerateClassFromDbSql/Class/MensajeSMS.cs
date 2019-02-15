using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MensajeSMS.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MensajeSMS 
    {
        public int IdMensaje { get; set; }
        public string Telefono { get; set; }
        public string Texto { get; set; }
    }
}      
