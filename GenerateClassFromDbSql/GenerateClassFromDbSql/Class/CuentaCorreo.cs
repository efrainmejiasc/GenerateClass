using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a CuentaCorreo.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class CuentaCorreo 
    {
        public int IdCuentaCorreo { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public string Servidor { get; set; }
        public int Puerto { get; set; }
        public bool SSL { get; set; }
        public int Orden { get; set; }
    }
}      
