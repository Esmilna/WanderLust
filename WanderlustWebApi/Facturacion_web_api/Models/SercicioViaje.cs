using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturacion_web_api.Models
{
    public class SercicioViaje
    {
        [Key]
        public int Id { get; set; }
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        [ForeignKey("IdProveedor")]
        public ProveedorServicio ProveedorServicio { get; set; }
    }
}
