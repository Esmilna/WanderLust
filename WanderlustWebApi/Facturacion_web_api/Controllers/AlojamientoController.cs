using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlojamientoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public AlojamientoController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<Alojamiento> GetAlojamientos()
        {
            return _db.Alojamiento.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{AlojamientoNombre}", Name = "GetAlojamientoByNombre")]
        public Alojamiento GetAlojamientoByNombre(string AlojamientoNombre)
        {
            return _db.Alojamiento.FirstOrDefault(I => I.NombreHotel == AlojamientoNombre);
        }
        [HttpGet("{AlojamientoId:int}", Name = "GetAlojamiento")]
        public Alojamiento GetAlojamiento(int AlojamientoId)
        {
            return _db.Alojamiento.FirstOrDefault(I => I.Id == AlojamientoId);
        }
        [HttpPost]
        public bool CrearAlojamiento(Alojamiento Alojamiento)
        {
            _db.Alojamiento.Add(Alojamiento);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarAlojamiento")]
        public bool ActualizarAlojamiento([FromBody] Alojamiento Alojamiento)
        {
            _db.Alojamiento.Update(Alojamiento);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{AlojamientoId:int}", Name = "BorrarAlojamiento")]
        public bool BorrarAlojamiento(int AlojamientoId, Alojamiento Alojamiento)
        {
            _db.Alojamiento.Remove(Alojamiento);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
