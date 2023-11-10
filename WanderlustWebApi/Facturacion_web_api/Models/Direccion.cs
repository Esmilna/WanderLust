using System.ComponentModel.DataAnnotations;

namespace Facturacion_web_api.Models
{
    public class Direccion
    {
        [Key]
        public int Id { get; set; }
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public string Sector { get; set; }

    }
}
