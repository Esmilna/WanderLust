using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleViajeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public DetalleViajeController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<DetalleViaje> GetDetalleViajes()
        {
            return _db.DetalleViaje.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{DetalleViajeNombre}", Name = "GetDetalleViajeByNombre")]
        public DetalleViaje GetDetalleViajeByNombre(string DetalleViajeNombre)
        {
            return _db.DetalleViaje.FirstOrDefault(I => I.Destino == DetalleViajeNombre);
        }
        [HttpGet("{DetalleViajeId:int}", Name = "GetDetalleViaje")]
        public DetalleViaje GetDetalleViaje(int DetalleViajeId)
        {
            return _db.DetalleViaje.FirstOrDefault(I => I.Id == DetalleViajeId);
        }
        [HttpPost]
        public bool CrearDetalleViaje(DetalleViaje DetalleViaje)
        {
            _db.DetalleViaje.Add(DetalleViaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarDetalleViaje")]
        public bool ActualizarDetalleViaje([FromBody] DetalleViaje DetalleViaje)
        {
            _db.DetalleViaje.Update(DetalleViaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{DetalleViajeId:int}", Name = "BorrarDetalleViaje")]
        public bool BorrarDetalleViaje(int DetalleViajeId, DetalleViaje DetalleViaje)
        {
            _db.DetalleViaje.Remove(DetalleViaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
