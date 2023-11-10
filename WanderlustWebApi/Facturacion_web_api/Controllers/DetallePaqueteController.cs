using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallePaqueteController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public DetallePaqueteController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<DetallePaquete> GetDetallePaquetes()
        {
            return _db.DetallePaquete.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{DetallePaqueteNombre}", Name = "GetDetallePaqueteByNombre")]
        public DetallePaquete GetDetallePaqueteByNombre(string DetallePaqueteNombre)
        {
            return _db.DetallePaquete.FirstOrDefault(I => I.NombrePaquete == DetallePaqueteNombre);
        }
        [HttpGet("{DetallePaqueteId:int}", Name = "GetDetallePaquete")]
        public DetallePaquete GetDetallePaquete(int DetallePaqueteId)
        {
            return _db.DetallePaquete.FirstOrDefault(I => I.Id == DetallePaqueteId);
        }
        [HttpPost]
        public bool CrearDetallePaquete(DetallePaquete DetallePaquete)
        {
            _db.DetallePaquete.Add(DetallePaquete);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarDetallePaquete")]
        public bool ActualizarDetallePaquete([FromBody] DetallePaquete DetallePaquete)
        {
            _db.DetallePaquete.Update(DetallePaquete);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{DetallePaqueteId:int}", Name = "BorrarDetallePaquete")]
        public bool BorrarDetallePaquete(int DetallePaqueteId, DetallePaquete DetallePaquete)
        {
            _db.DetallePaquete.Remove(DetallePaquete);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
