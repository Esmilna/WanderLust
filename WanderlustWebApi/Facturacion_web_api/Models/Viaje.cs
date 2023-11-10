using System.ComponentModel.DataAnnotations;

namespace Facturacion_web_api.Models
{
    public class Viaje
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Destino { get; set; }
        public string DuracionViaje { get; set; }
        public string UrlImagen { get; set; }
        public DateTime Fecha { get; set; }
        public float Precio { get; set; }
    }
}
