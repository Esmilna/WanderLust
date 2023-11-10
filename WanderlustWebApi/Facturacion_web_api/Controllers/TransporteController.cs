using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransporteController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public TransporteController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<Transporte> GetTransportes()
        {
            return _db.Transporte.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{TransporteNombre}", Name = "GetTransporteByNombre")]
        public Transporte GetTransporteByNombre(string TransporteNombre)
        {
            return _db.Transporte.FirstOrDefault(I => I.Identificacion == TransporteNombre);
        }
        [HttpGet("{TransporteId:int}", Name = "GetTransporte")]
        public Transporte GetTransporte(int TransporteId)
        {
            return _db.Transporte.FirstOrDefault(I => I.Id == TransporteId);
        }
        [HttpPost]
        public bool CrearTransporte(Transporte Transporte)
        {
            _db.Transporte.Add(Transporte);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarTransporte")]
        public bool ActualizarTransporte([FromBody] Transporte Transporte)
        {
            _db.Transporte.Update(Transporte);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{TransporteId:int}", Name = "BorrarTransporte")]
        public bool BorrarTransporte(int TransporteId, Transporte Transporte)
        {
            _db.Transporte.Remove(Transporte);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
