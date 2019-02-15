using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a TransicionEstadoEntidadPerfil.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class TransicionEstadoEntidadPerfil 
    {
        public int IdTransicionEstadoEntidadPerfil { get; set; }
        public int IdEstadoEntidadOrigen { get; set; }
        public int IdEstadoEntidadDestino { get; set; }
        public int IdPerfil { get; set; }
        public string Observaciones { get; set; }
    }
}      
