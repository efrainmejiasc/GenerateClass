using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a MeliponarioCaja.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class MeliponarioCaja 
    {
        public int IdMeliponarioCaja { get; set; }
        public string Identificador { get; set; }
        public int IdMeliponario { get; set; }
        public int IdEspecieAbeja { get; set; }
        public DateTime FechaEntregaAlProductor { get; set; }
        public string Comentario { get; set; }
        public int IdOrigenColonia { get; set; }
        public bool Activa { get; set; }
        public string Estado { get; set; }
    }
}      
