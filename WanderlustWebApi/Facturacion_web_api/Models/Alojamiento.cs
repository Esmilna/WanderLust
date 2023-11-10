using System.ComponentModel.DataAnnotations;

namespace Facturacion_web_api.Models
{
    public class Alojamiento
    {
        [Key]
        public int Id { get; set; }
        public string NombreHotel { get; set; }
        public string Ubicacion { get; set; }
        //Se debe crear tipo de habitacion como una tabla
        public string TipoHabitacion { get; set; }
        public float  Precio { get; set; }
    }
}
