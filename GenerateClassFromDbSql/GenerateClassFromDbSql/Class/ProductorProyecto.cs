using System;
namespace FloraNueva_RestFullApi
{
    /// <summary>
    /// Represents a ProductorProyecto.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProductorProyecto 
    {
        public int IdProductorProyecto { get; set; }
        public  string Identificador { get; set; }
        public int IdProductor { get; set; }
        public int IdProyecto { get; set; }
        public bool EstatusIntegracion { get; set; }
        public DateTime FechaIntegracion { get; set; }
        public DateTime FechaSalida { get; set; }
        public string RazonSalida { get; set; }
        public string Estado { get; set; }
    }
}      
