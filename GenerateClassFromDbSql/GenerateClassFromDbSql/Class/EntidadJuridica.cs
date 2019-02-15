using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a EntidadJuridica.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class EntidadJuridica 
    {
        public int IdEntidadJuridica { get; set; }
        public int IdTipoPeriodoFiscal { get; set; }
        public int IdMonedaBaseContabilidad { get; set; }
        public int? IdPais { get; set; }
        public int? IdUbicacionFisica { get; set; }
        public int? IdTipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string RazonSocial { get; set; }
        public string NombreContacto { get; set; }
        public string CorreoElectronicoContacto { get; set; }
        public string CodigoPaisTelefonoContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string InformacionCuentasBancarias { get; set; }
        public string OtrasSennas { get; set; }
        public string Observaciones { get; set; }
        public bool Activo { get; set; }
        public int IdEmpresa { get; set; }
        public bool? CRIEmitirComprobantesElectronicos { get; set; }
        public bool? CRIFacturaUtilizandoTiqueteElectronico { get; set; }
        public string CRIATVUsuario { get; set; }
        public string CRIATVContrasenna { get; set; }
        public string CRIATVLlaveCriptograficaNombre { get; set; }
        public byte[]? CRIATVLlaveCriptograficaArchivo { get; set; }
        public string CRIATVPIN { get; set; }
    }
}      
