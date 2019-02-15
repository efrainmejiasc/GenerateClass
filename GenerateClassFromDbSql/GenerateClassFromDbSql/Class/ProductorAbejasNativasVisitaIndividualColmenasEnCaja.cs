using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorAbejasNativasVisitaIndividualColmenasEnCaja.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorAbejasNativasVisitaIndividualColmenasEnCaja 
    {
        public int IdProductorAbejasNativasVisitaIndividualColmenasEnCaja { get; set; }
        public string  Identificador { get; set; }
        public int IdProductorAbejasNativasVisitaIndividual { get; set; }
        public int IdEspecieAbeja { get; set; }
        public bool ACFN { get; set; }
        public bool Rustica { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
    }
}      
