using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturacion_web_api.Models
{
    public class DetalleReserva
    {
        [Key]
        public int Id { get; set; }
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdFactura { get; set; }
        public int IdViaje { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [ForeignKey("IdReserva")]
        public Reserva Reserva { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
        [ForeignKey("IdFactura")]
        public Factura Factura { get; set; }
        [ForeignKey("IdViaje")]
        public Viaje Viaje { get; set; }
    }
}

