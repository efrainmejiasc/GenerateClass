using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Bitacora.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Bitacora 
    {
        public int IdBitacora { get; set; }
        public int IdTipoEvento { get; set; }
        public int IdUsuario { get; set; }
        public int? IdLocal { get; set; }
        public int? IdAplicacionOrigen { get; set; }
        public DateTime Fecha { get; set; }
        public string Entidad { get; set; }
        public string Accion { get; set; }
        public string Descripcion { get; set; }
        public string IP { get; set; }
        public string Dispositivo { get; set; }
    }
}      
