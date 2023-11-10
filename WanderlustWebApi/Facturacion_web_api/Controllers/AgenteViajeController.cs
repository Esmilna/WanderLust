using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenteViajeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        

        public AgenteViajeController(ApplicationDbContext db) 
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<AgenteViaje> GetAgenteViajes()
        {
            return _db.AgenteViaje.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{AgenteViajeNombre}", Name = "GetAgenteViajeByNombre")]
        public AgenteViaje GetAgenteViajeByNombre(string AgenteViajeNombre)
        {
            return _db.AgenteViaje.FirstOrDefault(I => I.Nombre == AgenteViajeNombre);
        }
        [HttpGet("{AgenteViajeId:int}", Name = "GetAgenteViaje")]
        public AgenteViaje GetAgenteViaje(int AgenteViajeId)
        {
            return _db.AgenteViaje.FirstOrDefault(I => I.Id == AgenteViajeId);
        }
        [HttpPost]
        public bool CrearAgenteViaje(AgenteViaje AgenteViaje)
        {
            _db.AgenteViaje.Add(AgenteViaje);            
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch( Name = "ActualizarAgenteViaje")]
        public bool ActualizarAgenteViaje([FromBody]AgenteViaje AgenteViaje)
        {
            _db.AgenteViaje.Update(AgenteViaje);           
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{agenteViajeId:int}", Name = "BorrarAgenteViaje")]
        public bool BorrarAgenteViaje(int agenteViajeId, AgenteViaje AgenteViaje)
        {
            _db.AgenteViaje.Remove(AgenteViaje);            
            return _db.SaveChanges() >= 0 ? true : false;
        }  
    }
}
