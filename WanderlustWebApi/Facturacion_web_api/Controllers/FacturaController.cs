using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public FacturaController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<Factura> GetFacturas()
        {
            return _db.Factura.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{FacturaNombre}", Name = "GetFacturaByNombre")]
        public Factura GetFacturaByNombre(string FacturaNombre)
        {
            return _db.Factura.FirstOrDefault(I => I.Identificacion == FacturaNombre);
        }
        [HttpGet("{FacturaId:int}", Name = "GetFactura")]
        public Factura GetFactura(int FacturaId)
        {
            return _db.Factura.FirstOrDefault(I => I.Id == FacturaId);
        }
        [HttpPost]
        public bool CrearFactura(Factura Factura)
        {
            _db.Factura.Add(Factura);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarFactura")]
        public bool ActualizarFactura([FromBody] Factura Factura)
        {
            _db.Factura.Update(Factura);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{FacturaId:int}", Name = "BorrarFactura")]
        public bool BorrarFactura(int FacturaId, Factura Factura)
        {
            _db.Factura.Remove(Factura);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
