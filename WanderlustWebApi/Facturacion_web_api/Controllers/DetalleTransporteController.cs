using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleTransporteController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public DetalleTransporteController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<DetalleTransporte> GetDetalleTransportes()
        {
            return _db.DetalleTransporte.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{DetalleTransporteNombre}", Name = "GetDetalleTransporteByNombre")]
       /* public DetalleTransporte GetDetalleTransporteByNombre(string DetalleTransporteNombre)
        {
            return _db.DetalleTransporte.FirstOrDefault(I => I.NombreHotel == DetalleTransporteNombre);
        }*/
        [HttpGet("{DetalleTransporteId:int}", Name = "GetDetalleTransporte")]
        public DetalleTransporte GetDetalleTransporte(int DetalleTransporteId)
        {
            return _db.DetalleTransporte.FirstOrDefault(I => I.Id == DetalleTransporteId);
        }
        [HttpPost]
        public bool CrearDetalleTransporte(DetalleTransporte DetalleTransporte)
        {
            _db.DetalleTransporte.Add(DetalleTransporte);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarDetalleTransporte")]
        public bool ActualizarDetalleTransporte([FromBody] DetalleTransporte DetalleTransporte)
        {
            _db.DetalleTransporte.Update(DetalleTransporte);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{DetalleTransporteId:int}", Name = "BorrarDetalleTransporte")]
        public bool BorrarDetalleTransporte(int DetalleTransporteId, DetalleTransporte DetalleTransporte)
        {
            _db.DetalleTransporte.Remove(DetalleTransporte);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
