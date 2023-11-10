using System.ComponentModel.DataAnnotations;

namespace Facturacion_web_api.Models
{
    public class Transporte
    {
        [Key]
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string TipoTransporte { get; set; }
        public string Itiner { get; set; }

    }
}
