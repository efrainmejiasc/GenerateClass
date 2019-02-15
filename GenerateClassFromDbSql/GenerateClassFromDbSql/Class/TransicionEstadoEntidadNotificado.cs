using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a TransicionEstadoEntidadNotificado.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class TransicionEstadoEntidadNotificado 
    {
        public int IdTransicionEstadoEntidadNotificado { get; set; }
        public int IdEstadoEntidadOrigen { get; set; }
        public int IdEstadoEntidadDestino { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTipoMensaje { get; set; }
        public int IdCuentaCorreo { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Observaciones { get; set; }
    }
}      
