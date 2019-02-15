using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MensajeBitacora.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MensajeBitacora 
    {
        public int IdMensajeBitacora { get; set; }
        public int IdMensaje { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string Texto { get; set; }
    }
}      
