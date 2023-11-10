using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ReservaController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<Reserva> GetReservas()
        {
            return _db.Reserva.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{ReservaNombre}", Name = "GetReservaByNombre")]
        public Reserva GetReservaByNombre(string ReservaNombre)
        {
            return _db.Reserva.FirstOrDefault(I => I.EstadoReserva == ReservaNombre);
        }
        [HttpGet("{ReservaId:int}", Name = "GetReserva")]
        public Reserva GetReserva(int ReservaId)
        {
            return _db.Reserva.FirstOrDefault(I => I.Id == ReservaId);
        }
        [HttpGet("All/{ReservaId:int}", Name = "GetAllReservas")]
        public IEnumerable<Reserva> GetAllReservas(int ReservaId)
        {
            return _db.Reserva.Where(I => I.IdViaje == ReservaId).ToList();
        }
        [HttpPost]
        public bool CrearReserva(Reserva Reserva)
        {
            _db.Reserva.Add(Reserva);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarReserva")]
        public bool ActualizarReserva([FromBody] Reserva Reserva)
        {
            _db.Reserva.Update(Reserva);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{ReservaId:int}", Name = "BorrarReserva")]
        public bool BorrarReserva(int ReservaId)
        {
            /*var reservaById =  _db.Reserva.FirstOrDefault(I => I.Id == ReservaId);
            _db.Reserva.Remove(Reserva);*/

            var reservaById = _db.Reserva.FirstOrDefault(I => I.Id == ReservaId);
            _db.Reserva.Remove(reservaById);


            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
