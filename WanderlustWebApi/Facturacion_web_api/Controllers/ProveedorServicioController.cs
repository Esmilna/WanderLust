using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorServicioController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ProveedorServicioController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<ProveedorServicio> GetProveedorServicios()
        {
            return _db.ProveedorServicio.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{ProveedorServicioNombre}", Name = "GetProveedorServicioByNombre")]
        public ProveedorServicio GetProveedorServicioByNombre(string ProveedorServicioNombre)
        {
            return _db.ProveedorServicio.FirstOrDefault(I => I.NombreProveedor == ProveedorServicioNombre);
        }
        [HttpGet("{ProveedorServicioId:int}", Name = "GetProveedorServicio")]
        public ProveedorServicio GetProveedorServicio(int ProveedorServicioId)
        {
            return _db.ProveedorServicio.FirstOrDefault(I => I.Id == ProveedorServicioId);
        }
        [HttpPost]
        public bool CrearProveedorServicio(ProveedorServicio ProveedorServicio)
        {
            _db.ProveedorServicio.Add(ProveedorServicio);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarProveedorServicio")]
        public bool ActualizarProveedorServicio([FromBody] ProveedorServicio ProveedorServicio)
        {
            _db.ProveedorServicio.Update(ProveedorServicio);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{ProveedorServicioId:int}", Name = "BorrarProveedorServicio")]
        public bool BorrarProveedorServicio(int ProveedorServicioId, ProveedorServicio ProveedorServicio)
        {
            _db.ProveedorServicio.Remove(ProveedorServicio);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
