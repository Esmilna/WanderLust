using Facturacion_web_api.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Facturacion_web_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {  
        }
        public DbSet<AgenteViaje> AgenteViaje { get; set; }
        public DbSet<Alojamiento> Alojamiento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ComentariosYValoraciones> ComentariosYValoraciones { get; set; }
        public DbSet<DetallePaquete> DetallePaquete { get; set; }
        public DbSet<DetalleReserva> DetalleReserva { get; set; }
        public DbSet<DetalleTransporte> DetalleTransporte { get; set; }
        public DbSet<DetalleViaje> DetalleViaje { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<EstadoReserva> EstadoReserva { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<PaqueteViaje> PaqueteViaje { get; set; }
        public DbSet<ProveedorServicio> ProveedorServicio { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<SercicioViaje> SercicioViaje { get; set; }
        public DbSet<Transporte> Transporte { get; set; }
        public DbSet<Viaje> Viaje { get; set; }




    }
}
