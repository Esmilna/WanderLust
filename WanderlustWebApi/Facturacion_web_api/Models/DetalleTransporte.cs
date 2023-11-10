using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturacion_web_api.Models
{
    public class DetalleTransporte
    {
        [Key]
        public int Id { get; set; }
        public int IdViaje { get; set; }
        public int IdTransporte { get; set; }
        [ForeignKey("IdViaje")]
        public Viaje Viaje { get; set; }
        [ForeignKey("IdTransporte")]
        public Transporte Transporte { get; set; }
    }
}
