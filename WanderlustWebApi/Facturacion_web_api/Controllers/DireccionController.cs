using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DireccionController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public DireccionController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<Direccion> GetDireccions()
        {
            return _db.Direccion.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{DireccionNombre}", Name = "GetDireccionByNombre")]
        //TODO: Se debe modificar para buscar por los 3 criterios de busqueda de dicha tabla
        public Direccion GetDireccionByNombre(string DireccionNombre)
        {
            return _db.Direccion.FirstOrDefault(I => I.Provincia == DireccionNombre);
        }
        [HttpGet("{DireccionId:int}", Name = "GetDireccion")]
        public Direccion GetDireccion(int DireccionId)
        {
            return _db.Direccion.FirstOrDefault(I => I.Id == DireccionId);
        }
        [HttpPost]
        public bool CrearDireccion(Direccion Direccion)
        {
            _db.Direccion.Add(Direccion);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarDireccion")]
        public bool ActualizarDireccion([FromBody] Direccion Direccion)
        {
            _db.Direccion.Update(Direccion);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{DireccionId:int}", Name = "BorrarDireccion")]
        public bool BorrarDireccion(int DireccionId, Direccion Direccion)
        {
            _db.Direccion.Remove(Direccion);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}

