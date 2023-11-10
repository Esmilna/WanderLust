using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleReservaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public DetalleReservaController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<DetalleReserva> GetDetalleReservas()
        {
            return _db.DetalleReserva.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{DetalleReservaNombre}", Name = "GetDetalleReservaByNombre")]
        public DetalleReserva GetDetalleReservaByNombre(string DetalleReservaNombre)
        {
            return _db.DetalleReserva.FirstOrDefault(I => I.Nombre == DetalleReservaNombre);
        }
        [HttpGet("{DetalleReservaId:int}", Name = "GetDetalleReserva")]
        public DetalleReserva GetDetalleReserva(int DetalleReservaId)
        {
            return _db.DetalleReserva.FirstOrDefault(I => I.Id == DetalleReservaId);
        }
        [HttpPost]
        public bool CrearDetalleReserva(DetalleReserva DetalleReserva)
        {
            _db.DetalleReserva.Add(DetalleReserva);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarDetalleReserva")]
        public bool ActualizarDetalleReserva([FromBody] DetalleReserva DetalleReserva)
        {
            _db.DetalleReserva.Update(DetalleReserva);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{DetalleReservaId:int}", Name = "BorrarDetalleReserva")]
        public bool BorrarDetalleReserva(int DetalleReservaId, DetalleReserva DetalleReserva)
        {
            _db.DetalleReserva.Remove(DetalleReserva);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
