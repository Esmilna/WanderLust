using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturacion_web_api.Models
{
    public class DetallePaquete
    {
        [Key]
        public int Id { get; set; }
        public int IdSerivicioViaje { get; set; }
        public int IdViaje { get; set; }
        public int IdPaqueteViaje { get; set; }
        public string NombrePaquete { get; set; }
        public string DescripcionPaquete { get; set; }
        public string Destino { get; set; }
        public string DuracionViaje { get; set; }
        public float Precio { get; set; }
        [ForeignKey("IdSerivicioViaje")]
        public SercicioViaje SercicioViaje { get; set; }
        [ForeignKey("IdViaje")]
        public Viaje Viaje { get; set; }
        [ForeignKey("IdPaqueteViaje")]
        public PaqueteViaje PaqueteViaje {get;set;}
    }
}
