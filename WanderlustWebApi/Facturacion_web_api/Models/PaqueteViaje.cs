using System.ComponentModel.DataAnnotations;

namespace Facturacion_web_api.Models
{
    public class PaqueteViaje
    {
        [Key]
        public int Id { get; set; }
        public string NombrePaquete { get; set; }
        public string DescripcionPaquete { get; set; }
        public string Destino { get; set; }
        public string Duracionviaje { get; set; }
        public float Precio { get; set; }
    }
}
