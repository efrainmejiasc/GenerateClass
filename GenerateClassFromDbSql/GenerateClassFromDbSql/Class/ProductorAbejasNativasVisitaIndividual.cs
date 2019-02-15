using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorAbejasNativasVisitaIndividual.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorAbejasNativasVisitaIndividual 
    {
        public int IdProductorAbejasNativasVisitaIndividual { get; set; }
        public string  Identificador { get; set; }
        public int? IdProductor { get; set; }
        public DateTime Fecha { get; set; }
        public bool ElMeliponicultorEstaPresente { get; set; }
        public string OtraPersonaPresente { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
        public string Recomendaciones { get; set; }
        public string Otros { get; set; }
        public string Estado { get; set; }
    }
}      
