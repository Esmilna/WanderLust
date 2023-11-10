using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaqueteViajeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public PaqueteViajeController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<PaqueteViaje> GetPaqueteViajes()
        {
            return _db.PaqueteViaje.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{PaqueteViajeNombre}", Name = "GetPaqueteViajeByNombre")]
        public PaqueteViaje GetPaqueteViajeByNombre(string PaqueteViajeNombre)
        {
            return _db.PaqueteViaje.FirstOrDefault(I => I.NombrePaquete == PaqueteViajeNombre);
        }
        [HttpGet("{PaqueteViajeId:int}", Name = "GetPaqueteViaje")]
        public PaqueteViaje GetPaqueteViaje(int PaqueteViajeId)
        {
            return _db.PaqueteViaje.FirstOrDefault(I => I.Id == PaqueteViajeId);
        }
        [HttpPost]
        public bool CrearPaqueteViaje(PaqueteViaje PaqueteViaje)
        {
            _db.PaqueteViaje.Add(PaqueteViaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarPaqueteViaje")]
        public bool ActualizarPaqueteViaje([FromBody] PaqueteViaje PaqueteViaje)
        {
            _db.PaqueteViaje.Update(PaqueteViaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{PaqueteViajeId:int}", Name = "BorrarPaqueteViaje")]
        public bool BorrarPaqueteViaje(int PaqueteViajeId, PaqueteViaje PaqueteViaje)
        {
            _db.PaqueteViaje.Remove(PaqueteViaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
