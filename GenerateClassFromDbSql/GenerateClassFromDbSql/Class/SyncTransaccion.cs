using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a SyncTransaccion.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class SyncTransaccion 
    {
        public Int64 Numero { get; set; }
        public Guid Version { get; set; }
        public string Usuario { get; set; }
        public string Dispositivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string FechaCreacionUtc { get; set; }
        public string Estado { get; set; }
    }
}      
