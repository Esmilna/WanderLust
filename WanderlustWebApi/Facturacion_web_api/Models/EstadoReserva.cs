using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturacion_web_api.Models
{
    public class EstadoReserva
    {
        [Key]
        public int Id { get; set; }
        public int IdReserva { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [ForeignKey("IdReserva")]
        public Reserva Reserva { get; set; }
    }
}
