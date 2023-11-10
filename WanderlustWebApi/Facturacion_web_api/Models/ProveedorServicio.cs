using System.ComponentModel.DataAnnotations;

namespace Facturacion_web_api.Models
{
    public class ProveedorServicio
    {
        [Key]
        public int Id { get; set; }
        public string NombreProveedor { get; set; }
        public string TipoServicio { get; set; }
        public string Contacto { get; set; }
    }
}
