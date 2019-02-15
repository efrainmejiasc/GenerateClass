using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a UbicacionFisica.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class UbicacionFisica 
    {
        public int IdUbicacionFisica { get; set; }
        public int? IdUbicacionFisicalPadre { get; set; }
        public int IdPais { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
        public string Orden { get; set; }
        public bool Hoja { get; set; }
        public bool Activa { get; set; }
    }
}      
