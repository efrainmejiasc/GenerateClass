using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a Perfil.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Perfil 
    {
        public int IdPerfil { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool SuperAdministrador { get; set; }
        public bool Visible { get; set; }
    }
}      
