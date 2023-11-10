using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturacion_web_api.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public int IdDireccion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string DNI { get; set; }
        [ForeignKey("IdDireccion")]
        public Direccion Direccion { get; set; }
    }
}
