using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorTrack.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorTrack 
    {
        public int IdProductor { get; set; }
        public Guid Identificador { get; set; }
        public int? IdUsuarioEncuestador { get; set; }
        public DateTime? FechaEncuesta { get; set; }
        public bool? VisitaALaCasa { get; set; }
        public int? IdEstadoDiagnostico { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public byte[]? Foto { get; set; }
        public string CodigoFloraNueva { get; set; }
        public bool? Sexo { get; set; }
        public string NumeroCedula { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdEstadoCivil { get; set; }
        public string PerteneceAAlgunGrupoEtnico { get; set; }
        public int? IdPais { get; set; }
        public int? IdGrupo { get; set; }
        public int? IdDivisionAdministrativa1 { get; set; }
        public int? IdDivisionAdministrativa2 { get; set; }
        public int? IdDivisionAdministrativa3 { get; set; }
        public string DivisionAdministrativa4 { get; set; }
        public string DireccionExacta { get; set; }
        public int? IdTerritorio { get; set; }
        public decimal? GPSLatitud { get; set; }
        public decimal? GPSLongitud { get; set; }
        public decimal? Altitud { get; set; }
        public string ComentariosUbicacion { get; set; }
        public string ActividadLaboralPrincipal { get; set; }
        public string ActividadLaboralSecundaria { get; set; }
        public int? IdCategoriaActividadPrincipal { get; set; }
        public int? IdActividadAgricola { get; set; }
        public int? TotalPersonasHogar { get; set; }
        public int? TotalPersonasActivasEconomicamente { get; set; }
        public int? TotalPersonasDependientes { get; set; }
        public decimal? IndiceInsercionLaboralProductor { get; set; }
        public decimal? IndiceNivelEducativoProductor { get; set; }
        public decimal? IndiceCiudadaniaSocialProductor { get; set; }
        public decimal? IndiceInsercionProductivaProductor { get; set; }
        public decimal? IndiceInclusionSocialProductor { get; set; }
        public decimal? IndiceInsercionLaboralHogar { get; set; }
        public decimal? IndiceNivelEducativoHogar { get; set; }
        public decimal? IndiceCiudadaniaSocialHogar { get; set; }
        public decimal? IndiceInsercionProductivaHogar { get; set; }
        public decimal? TasaActividadEconomicaHogar { get; set; }
        public decimal? IndiceInclusionSocialHogar { get; set; }
        public int? IdFacilidadAccesoComunidad { get; set; }
        public int? IdFacilidadAccesoVivienda { get; set; }
        public decimal? IndiceFacilidadAcceso { get; set; }
        public int? IdTiempoLlegarCentroEducativo { get; set; }
        public int? IdTiempoLlegarCentroSalud { get; set; }
        public decimal? IndiceCercaniaCentrosBasicos { get; set; }
        public int? IdExistenciaTransportePublico { get; set; }
        public int? IdPosesionMedioTransportePublico { get; set; }
        public string EspecificarMediosTransporte { get; set; }
        public decimal? IndiceCapacidadDesplazamiento { get; set; }
        public decimal? IndiceConexionProximidadGeografica { get; set; }
        public int? IdEstructuraGeneracionalHogar { get; set; }
        public bool? OtrosFamiliaresVivenEnLaMismaComunidad { get; set; }
        public int? IdUstedConsideraContarConApoyoDeSuFamilia { get; set; }
        public decimal? IndiceCercaniaRelacionFamiliar { get; set; }
        public int? IdApoyoVecinosCasoNecesidad { get; set; }
        public int? IdAmbienteSocialComunidad { get; set; }
        public bool? SeSienteUstedRealmenteParteComunidad { get; set; }
        public bool? UstedEsUnMiembroActivoDeAlgunGrupo { get; set; }
        public string MiembroActivoEspecificar { get; set; }
        public decimal? IndiceCercaniaRelacionComunidad { get; set; }
        public decimal? IndiceRelacionesSociales { get; set; }
        public decimal? IndiceGlobalBienestarSocialFamiliar { get; set; }
        public int? IdSuViviendaEs { get; set; }
        public int? IdLaViviendaEsANombreSuyo { get; set; }
        public string LaViviendaEsANombreSuyoEspecificar { get; set; }
        public int? IdEstadoGeneralViviendaACFN { get; set; }
        public int? IdEstadoGeneralViviendaProductor { get; set; }
        public int? CantidadDormitorios { get; set; }
        public int? HacinamientoPorDormitorios { get; set; }
        public decimal? IndiceHacinamiento { get; set; }
        public decimal? IndiceEstadoVivienda { get; set; }
        public decimal? IndiceVivienda { get; set; }
        public int? IdFuenteAguaVivienda { get; set; }
        public bool? AccesoALaElectricidad { get; set; }
        public decimal? IndiceServiciosBasicos { get; set; }
        public bool? TieneTelefonoResidencial { get; set; }
        public bool? TieneTelefonoCelular { get; set; }
        public bool? TieneSennalTelefoniaMovilEnSuCasa { get; set; }
        public bool? TieneAccesoAInternet { get; set; }
        public decimal? IndiceServiciosComunicacion { get; set; }
        public decimal? IndiceAccesoAServicios { get; set; }
        public bool? RecibeAyudaFinanciera { get; set; }
        public string RecibeAyudaFinancieraEspecificar { get; set; }
        public bool? PresupuestoSuficienteCubrirGastosBasicos { get; set; }
        public string ParaQueNoAlcanzaPresupuestoHogar { get; set; }
        public int? IdConLosIngresosUstedEstimaQue { get; set; }
        public decimal? MontoMinimoMensualParaVivir { get; set; }
        public int? IdConLaActualSituacionEconomica { get; set; }
        public int? IdUstedConsideraQueSuHogarEs { get; set; }
        public decimal? IndiceNivelVida { get; set; }
        public decimal? IndiceBienestarEconomicoMaterialHogar { get; set; }
        public bool? UstedProduceAlimentosParaSuHogar { get; set; }
        public bool? GranosBasicos { get; set; }
        public bool? Hortalizas { get; set; }
        public bool? Frutas { get; set; }
        public bool? AnimalesYSusProductos { get; set; }
        public bool? ProductosTransformados { get; set; }
        public bool? PlantasAromaticasYMedicinales { get; set; }
        public bool? QueProduceParaSuHogarOtros { get; set; }
        public int? IdProporcionAutoconsumoAlimentosHogar { get; set; }
        public int? IdLograProducir { get; set; }
        public int? IdDondeUstedProduce { get; set; }
        public int? IdElTamannoDeSuParcelaEs { get; set; }
        public int? IdAUstedLeGustaria { get; set; }
        public bool? TamannoParcela { get; set; }
        public bool? ManoObra { get; set; }
        public bool? FertilidadSuelos { get; set; }
        public bool? TiempoDisponible { get; set; }
        public bool? RecursosFinancierosInvertirYTrabajar { get; set; }
        public bool? RiesgosNaturalesMuyFrecuentes { get; set; }
        public bool? OtrasLimitantes { get; set; }
        public bool? NoPoseeTierras { get; set; }
        public bool? NoPoseeConocimientos { get; set; }
        public bool? TrabajaEnOtroSectorYNoTieneTiempo { get; set; }
        public bool? NoLeInteresaPrefiereComprar { get; set; }
        public bool? ElLugarNoEsAptoParaCultivar { get; set; }
        public bool? OtrasRazones { get; set; }
        public decimal? IndiceSoberaniaAlimenticia { get; set; }
        public decimal? FelicidadSuTrabajo { get; set; }
        public decimal? FelicidadSuSituacionFinanciera { get; set; }
        public decimal? FelicidadSuEstadoSalud { get; set; }
        public decimal? FelicidadSuVivienda { get; set; }
        public decimal? FelicidadSuTiempoLibre { get; set; }
        public decimal? FelicidadSuFamilia { get; set; }
        public decimal? FelicidadSuEducacion { get; set; }
        public decimal? FelicidadElMedioAmbiente { get; set; }
        public decimal? FelicidadSuVidaSocial { get; set; }
        public decimal? FelicidadSuParticipacionDentroComunidad { get; set; }
        public decimal? IndiceFelicidad { get; set; }
        public int? IdFormaJuridicaExplotacion { get; set; }
        public bool? PerteneceAUnaOrganizacionAgropecuaria { get; set; }
        public string NombreOrganizacionAgropecuaria { get; set; }
        public int? IdTenenciaDeLaTierra { get; set; }
        public bool? ANombreDeQuienEstaElTerreno { get; set; }
        public string SiEsANombreDeOtraPersonaEspecificar { get; set; }
        public string EspecificarUbicacionDeLaTierra { get; set; }
        public decimal? SuperficieDeLaParcela { get; set; }
        public string MiniDescripcionDeLaFinca { get; set; }
        public byte[]? FotoParcela { get; set; }
        public string CualEsSuProduccionPrincipal { get; set; }
        public string CualesSonLasOtrasProduccionesQueTiene { get; set; }
        public int? IdAbono { get; set; }
        public int? IdControlDeMaleza { get; set; }
        public int? IdPlaguicidas { get; set; }
        public int? IdOrigenDeLasSemillas { get; set; }
        public int? IdSistemaRiegoCultivos { get; set; }
        public bool? PoseeUnaCertificacion { get; set; }
        public string CertificacionEspecificar { get; set; }
        public int? IdCategoriaManejo { get; set; }
        public string ComentarioDeManejo { get; set; }
        public string ListaMaquinariaDisponibleEnLaFinca { get; set; }
        public int? IdCategoriaMecanizacion { get; set; }
        public string ListaInfraestructuraDisponibleEnLaFinca { get; set; }
        public int? IdCategoriaInfraestructura { get; set; }
        public bool? RealizaAlgunProcesoTransformacionOValorAgregado { get; set; }
        public string ProcesoTransformacionOValorAgregadoEspecificar { get; set; }
        public int? IdDestinoDeLaProduccion { get; set; }
        public string SiVentaEspecificarCanalesComercializacion { get; set; }
        public int? IdCategoriaExplotacionAgricola { get; set; }
        public int? IdOrientacionTecnicoEco { get; set; }
        public string ComentarioExplotacionAgricola { get; set; }
        public bool? TieneAbejasSinAguijon { get; set; }
        public DateTime? DesdeCuandoLasTiene { get; set; }
        public string OtrasEspeciesAbeja { get; set; }
        public string DondeYComoObtuvoEsasColmenas { get; set; }
        public bool? ProduceMiel { get; set; }
        public string ComoCosechaLaMiel { get; set; }
        public int? IdDestinoMiel { get; set; }
        public string DondeSeVendeMielEspecificar { get; set; }
        public decimal? PrecioVentaMiel { get; set; }
        public int? IdDondeColocaLasColmenas { get; set; }
        public string DondeSeUbicanLasColmenas { get; set; }
        public string DiagnosticoVisualDelMeliponarioYSuEntorno { get; set; }
        public int? IdPotencialLugarParaTenerAbejas { get; set; }
        public int? IdRiesgoRoboColmenas { get; set; }
        public byte[]? FotoMeliponario { get; set; }
        public string CualEsSuMotivacionParaTenerLasAbejas { get; set; }
        public string ComoAprendioACriarLasAbejas { get; set; }
        public int? IdNivelConocimientoMeliponicultura { get; set; }
        public string ComentariosMeliponicultura { get; set; }
        public string QueEsLoQueMejorariaSuCalidadDeVida { get; set; }
        public string CualesSonLosFrenosCalidadDeVida { get; set; }
        public string ComoMejorariaSuActividadAgricola { get; set; }
        public string CualesSonLosFrenosActividadAgricola { get; set; }
        public string EnQueLeGustariaQueACFNLoPuedaApoyar { get; set; }
        public string CualesSon3FortalezasDeSuComunidad { get; set; }
        public string CualesSon3PrincipalesProblemasComunidad { get; set; }
        public string QueSolucionesPropondriaMejorarComunidad { get; set; }
        public string CualesSonLosFrenosImpidenHacerEsasSoluciones { get; set; }
        public string Fortalezas { get; set; }
        public string Debilidades { get; set; }
        public string Oportunidades { get; set; }
        public string Amenazas { get; set; }
        public string ProyectosPotenciales { get; set; }
        public string ComentarioGeneral { get; set; }
        public decimal? IndicadorBienestarSocialYFamiliarDelHogar { get; set; }
        public decimal? IndicadorBienestarEconomicoYMaterialDelHogar { get; set; }
        public decimal? IndicadorSoberaniaAlimenticia { get; set; }
        public decimal? IndicadorFelicidad { get; set; }
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
