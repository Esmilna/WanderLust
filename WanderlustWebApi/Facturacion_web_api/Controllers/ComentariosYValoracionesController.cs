using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentariosYValoracionesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public ComentariosYValoracionesController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<ComentariosYValoraciones> GetComentariosYValoracioness()
        {
            return _db.ComentariosYValoraciones.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{ComentariosYValoracionesNombre}", Name = "GetComentariosYValoracionesByNombre")]
        public ComentariosYValoraciones GetComentariosYValoracionesByNombre(string ComentariosYValoracionesNombre)
        {
            return _db.ComentariosYValoraciones.FirstOrDefault(I => I.Comentario == ComentariosYValoracionesNombre);
        }
        [HttpGet("{ComentariosYValoracionesId:int}", Name = "GetComentariosYValoraciones")]
        public ComentariosYValoraciones GetComentariosYValoraciones(int ComentariosYValoracionesId)
        {
            return _db.ComentariosYValoraciones.FirstOrDefault(I => I.Id == ComentariosYValoracionesId);
        }
        [HttpPost]
        public bool CrearComentariosYValoraciones(ComentariosYValoraciones ComentariosYValoraciones)
        {
            _db.ComentariosYValoraciones.Add(ComentariosYValoraciones);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarComentariosYValoraciones")]
        public bool ActualizarComentariosYValoraciones([FromBody] ComentariosYValoraciones ComentariosYValoraciones)
        {
            _db.ComentariosYValoraciones.Update(ComentariosYValoraciones);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{ComentariosYValoracionesId:int}", Name = "BorrarComentariosYValoraciones")]
        public bool BorrarComentariosYValoraciones(int ComentariosYValoracionesId, ComentariosYValoraciones ComentariosYValoraciones)
        {
            _db.ComentariosYValoraciones.Remove(ComentariosYValoraciones);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
