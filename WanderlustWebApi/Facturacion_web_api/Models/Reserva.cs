using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturacion_web_api.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdViaje { get; set; }
        public string nombreCliente { get; set; }
        public string cedulaCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public DateTime InicioFechaReserva { get; set; }
        public DateTime FinFechaReserva { get; set; }
        public string EstadoReserva { get; set; }
    }
}
