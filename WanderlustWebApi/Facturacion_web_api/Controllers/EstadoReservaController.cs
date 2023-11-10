using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoReservaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public EstadoReservaController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<EstadoReserva> GetEstadoReservas()
        {
            return _db.EstadoReserva.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{EstadoReservaNombre}", Name = "GetEstadoReservaByNombre")]
        public EstadoReserva GetEstadoReservaByNombre(string EstadoReservaNombre)
        {
            return _db.EstadoReserva.FirstOrDefault(I => I.Nombre == EstadoReservaNombre);
        }
        [HttpGet("{EstadoReservaId:int}", Name = "GetEstadoReserva")]
        public EstadoReserva GetEstadoReserva(int EstadoReservaId)
        {
            return _db.EstadoReserva.FirstOrDefault(I => I.Id == EstadoReservaId);
        }
        [HttpPost]
        public bool CrearEstadoReserva(EstadoReserva EstadoReserva)
        {
            _db.EstadoReserva.Add(EstadoReserva);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarEstadoReserva")]
        public bool ActualizarEstadoReserva([FromBody] EstadoReserva EstadoReserva)
        {
            _db.EstadoReserva.Update(EstadoReserva);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{EstadoReservaId:int}", Name = "BorrarEstadoReserva")]
        public bool BorrarEstadoReserva(int EstadoReservaId, EstadoReserva EstadoReserva)
        {
            _db.EstadoReserva.Remove(EstadoReserva);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}

