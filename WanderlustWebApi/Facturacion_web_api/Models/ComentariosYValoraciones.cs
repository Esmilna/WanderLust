using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturacion_web_api.Models
{
    public class ComentariosYValoraciones
    {
        [Key]
        public int Id { get; set; }
        public int IdViaje { get; set; }
        public int IdPaquete { get; set; }
        public int IdCliente { get; set; }
        public string Comentario { get; set; }
        public float  Valoracion { get; set; }
        [ForeignKey("IdViaje")]
        public Viaje Viaje { get; set; }
        [ForeignKey("IdPaquete")]
        public PaqueteViaje PaqueteViaje { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

    }
}
