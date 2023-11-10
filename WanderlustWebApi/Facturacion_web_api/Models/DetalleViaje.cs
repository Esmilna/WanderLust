using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturacion_web_api.Models
{
    public class DetalleViaje
    {
        [Key]
        public int Id { get; set; }
        public int IdViaje { get; set; }
        public int IdAlojamiento { get; set; }
        public int IdCliente { get; set; }
        public int IdTransporte { get; set; }
        public int idPaqueteViaje { get; set; }
        public string Destino { get; set; }
        public string DuracionViaje { get; set; }
        public float Precio { get; set; }
        [ForeignKey("IdViaje")]
        public Viaje Viaje { get; set; }
        [ForeignKey("IdAlojamiento")]
        public Alojamiento Alojamiento { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
        [ForeignKey("IdTransporte")]
        public Transporte Transporte { get; set; }
        [ForeignKey("idPaqueteViaje")]
        public PaqueteViaje PaqueteViaje { get; set; }
    }
}
