using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SercicioViajeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public SercicioViajeController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<SercicioViaje> GetSercicioViajes()
        {
            return _db.SercicioViaje.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{SercicioViajeNombre}", Name = "GetSercicioViajeByNombre")]
        public SercicioViaje GetSercicioViajeByNombre(string SercicioViajeNombre)
        {
            return _db.SercicioViaje.FirstOrDefault(I => I.Nombre == SercicioViajeNombre);
        }
        [HttpGet("{SercicioViajeId:int}", Name = "GetSercicioViaje")]
        public SercicioViaje GetSercicioViaje(int SercicioViajeId)
        {
            return _db.SercicioViaje.FirstOrDefault(I => I.Id == SercicioViajeId);
        }
        [HttpPost]
        public bool CrearSercicioViaje(SercicioViaje SercicioViaje)
        {
            _db.SercicioViaje.Add(SercicioViaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarSercicioViaje")]
        public bool ActualizarSercicioViaje([FromBody] SercicioViaje SercicioViaje)
        {
            _db.SercicioViaje.Update(SercicioViaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{SercicioViajeId:int}", Name = "BorrarSercicioViaje")]
        public bool BorrarSercicioViaje(int SercicioViajeId, SercicioViaje SercicioViaje)
        {
            _db.SercicioViaje.Remove(SercicioViaje);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
