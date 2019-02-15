using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCajaAccion.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCajaAccion 
    {
        public int IdMeliponarioCajaAccion { get; set; }
        public string Identificador { get; set; }
        public int IdMeliponarioCaja { get; set; }
        public int IdTipoAccionMeliponario { get; set; }
        public int IdOrigenColonia { get; set; }
        public int IdUsuarioResponsable { get; set; }
        public DateTime FechaAccion { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }
    }
}      
