using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Local.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Local 
    {
        public int IdLocal { get; set; }
        public int? IdEntidadJuridica { get; set; }
        public int IdEmpresa { get; set; }
        public int? IdTerritorio { get; set; }
        public int? IdUbicacionFisica { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Observaciones { get; set; }
        public bool Activo { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public int UsuariosNoFacturables { get; set; }
        public decimal CostoUsuarioMensual { get; set; }
        public int IdMonedaCostoUsuarioMensual { get; set; }
        public bool? Moroso { get; set; }
    }
}      
