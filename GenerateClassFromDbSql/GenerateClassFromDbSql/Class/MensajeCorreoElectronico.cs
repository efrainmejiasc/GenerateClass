using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MensajeCorreoElectronico.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MensajeCorreoElectronico 
    {
        public int IdMensaje { get; set; }
        public int IdCuentaCorreoSalida { get; set; }
        public string Para { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Asunto { get; set; }
        public string Texto { get; set; }
    }
}      
