
using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a AbejasNativasVisitaGrupal.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AbejasNativasVisitaGrupal 
    {
        public int IdAbejasNativasVisitaGrupal { get; set; }
        public string Identificador { get; set; }
        public int IdGrupo { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string EquipoFloraNuevaPresente { get; set; }
        public string OtrosParticipantes { get; set; }
        public string TemaYObjetivoDeLaVisita { get; set; }
        public string DesarrolloDeLaVisitaAcciones { get; set; }
        public string MaterialEntregado { get; set; }
        public string ProblemasDetectados { get; set; }
        public string RecomendacionesProximaVisita { get; set; }
        public string Estado { get; set; }
    }
}      
