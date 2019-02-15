using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a AbejasNativasVisitaGrupalTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AbejasNativasVisitaGrupalTrack 
    {
        public int IdAbejasNativasVisitaGrupal { get; set; }
        public Guid Identificador { get; set; }
        public int? IdGrupo { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public string EquipoFloraNuevaPresente { get; set; }
        public string OtrosParticipantes { get; set; }
        public string TemaYObjetivoDeLaVisita { get; set; }
        public string DesarrolloDeLaVisitaAcciones { get; set; }
        public string MaterialEntregado { get; set; }
        public string ProblemasDetectados { get; set; }
        public string RecomendacionesProximaVisita { get; set; }
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
