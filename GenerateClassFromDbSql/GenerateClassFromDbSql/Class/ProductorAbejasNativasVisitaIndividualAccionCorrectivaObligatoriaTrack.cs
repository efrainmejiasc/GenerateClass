using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorAbejasNativasVisitaIndividualAccionCorrectivaObligatoriaTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorAbejasNativasVisitaIndividualAccionCorrectivaObligatoriaTrack 
    {
        public int IdProductorAbejasNativasV { get; set; }
        public Guid Identificador { get; set; }
        public int? IdProductorAbejasNativasVisitaIndividual { get; set; }
        public string AccionCorrectivaObligatoria { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Dispositivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string FechaCreacionUtc { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string FechaModificacionUtc { get; set; }
        public string Transaccion { get; set; }
    }
}      
