using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorAbejasNativasVisitaIndividualColmenasEnTrampa.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorAbejasNativasVisitaIndividualColmenasEnTrampa 
    {
        public int IdProductorAbejasNativasVisitaIndividualColmenasEnTrampa { get; set; }
        public string Identificador { get; set; }
        public int IdProductorAbejasNativasVisitaIndividual { get; set; }
        public int IdEspecieAbeja { get; set; }
        public bool EnMeliponario { get; set; }
        public bool EnCampo { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
    }
}      
