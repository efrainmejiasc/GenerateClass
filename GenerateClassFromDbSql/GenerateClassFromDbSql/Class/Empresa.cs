using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Empresa.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Empresa 
    {
        public int IdEmpresa { get; set; }
        public int IdMonedaBaseVentas { get; set; }
        public int IdTipoEmpresa { get; set; }
        public int IdPais { get; set; }
        public int IdTemaVisual { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public byte[]? Logo { get; set; }
        public bool Activo { get; set; }
        public string Direccion { get; set; }
        public string SitioWeb { get; set; }
        public string Observaciones { get; set; }
    }
}      
