using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a UbicacionLocal.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class UbicacionLocal 
    {
        public int IdUbicacionLocal { get; set; }
        public int? IdUbicacionLocalPadre { get; set; }
        public int IdLocal { get; set; }
        public int IdUsuarioResponsable { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public bool Activa { get; set; }
    }
}      
