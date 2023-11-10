using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViajeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public ViajeController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<Viaje> GetViajes()
        {
            return _db.Viaje.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{ViajeNombre}", Name = "GetViajeByNombre")]
        public Viaje GetViajeByNombre(string ViajeNombre)
        {
            return _db.Viaje.FirstOrDefault(I => I.Nombre == ViajeNombre);
        }
        [HttpGet("All/{ViajeId:int}", Name = "GetAllViajes")]
        public IEnumerable<Viaje> GetAllViajes(int ViajeId)
        {
            return _db.Viaje.Where(I => I.Id == ViajeId).ToList();
        }
        [HttpGet("{ViajeId:int}", Name = "GetViaje")]
        public Viaje GetViaje(int ViajeId)
        {
            return _db.Viaje.FirstOrDefault(I => I.Id == ViajeId);
        }
        [HttpPost]
        public bool CrearViaje(Viaje Viaje)
        {
            _db.Viaje.Add(Viaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarViaje")]
        public bool ActualizarViaje([FromBody] Viaje Viaje)
        {
            _db.Viaje.Update(Viaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{ViajeId:int}", Name = "BorrarViaje")]
        public bool BorrarViaje(int ViajeId)
        {
            var viajeById = _db.Viaje.FirstOrDefault(I => I.Id == ViajeId);
            _db.Viaje.Remove(viajeById);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
