using System.ComponentModel.DataAnnotations;

namespace Facturacion_web_api.Models
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public float MontoPagado { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }

    }
}
