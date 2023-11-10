using Facturacion_web_api.Data;
using Facturacion_web_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ICollection<Cliente> GetClientes()
        {
            return _db.Cliente.OrderBy(i => i.Id).ToList();
        }
        [HttpGet("{ClienteNombre}", Name = "GetClienteByNombre")]
        public Cliente GetClienteByNombre(string ClienteNombre)
        {
            return _db.Cliente.FirstOrDefault(I => I.Nombre == ClienteNombre);
        }
        [HttpGet("{ClienteId:int}", Name = "GetCliente")]
        public Cliente GetCliente(int ClienteId)
        {
            return _db.Cliente.FirstOrDefault(I => I.Id == ClienteId);
        }
        [HttpPost]
        public bool CrearCliente(Cliente Cliente)
        {
            _db.Cliente.Add(Cliente);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpPatch(Name = "ActualizarCliente")]
        public bool ActualizarCliente([FromBody] Cliente Cliente)
        {
            _db.Cliente.Update(Cliente);
            return _db.SaveChanges() >= 0 ? true : false;
        }
        [HttpDelete("{ClienteId:int}", Name = "BorrarCliente")]
        public bool BorrarCliente(int ClienteId, Cliente Cliente)
        {
            _db.Cliente.Remove(Cliente);
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
