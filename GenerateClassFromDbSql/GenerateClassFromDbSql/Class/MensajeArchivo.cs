using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MensajeArchivo.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MensajeArchivo 
    {
        public int IdMensajeArchivo { get; set; }
        public int IdMensaje { get; set; }
        public string Nombre { get; set; }
        public byte[] Archivo { get; set; }
        public string Observaciones { get; set; }
    }
}      
