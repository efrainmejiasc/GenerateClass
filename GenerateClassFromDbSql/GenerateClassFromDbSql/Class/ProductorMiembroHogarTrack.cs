using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorMiembroHogarTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorMiembroHogarTrack 
    {
        public int IdProductorMiembroHogar { get; set; }
        public Guid Identificador { get; set; }
        public int? IdProductor { get; set; }
        public string Nombre { get; set; }
        public int? IdParentezco { get; set; }
        public bool? Sexo { get; set; }
        public int? Edad { get; set; }
        public bool? TieneAlgunaDiscapacidadOEnfermedadGrave { get; set; }
        public string Ocupacion { get; set; }
        public int? IdCondicionLaboral { get; set; }
        public bool? SeguridadTrabajaTodoElAnno { get; set; }
        public bool? SeguridadTrabajaEntre48Y40Horas { get; set; }
        public bool? SeguridadCotizaALaCaja { get; set; }
        public bool? SeguridadGozaDeAlMenosUnoDeLosDerechosLaborales { get; set; }
        public bool? SeguridadPercibeSuEmpleoComoSeguro { get; set; }
        public decimal? IndiceSeguridad { get; set; }
        public int? IdSituacionAutoempleo { get; set; }
        public decimal? IndiceInsercionLaboral { get; set; }
        public int? IdSabeLeerYEscribir { get; set; }
        public int? IdNivelEscolar { get; set; }
        public decimal? IndiceNivelEducativo { get; set; }
        public int? IdCondicionAseguramiento { get; set; }
        public decimal? IndiceCiudadaniaSocial { get; set; }
        public int? IdPertenenciaGrupoComunitario { get; set; }
        public string PertenenciaGrupoComunitarioEspecificar { get; set; }
        public decimal? IndiceInclusionSocialPersona { get; set; }
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
