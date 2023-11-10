﻿// <auto-generated />
using System;
using Facturacion_web_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Facturacion_web_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230813192150_MigracionInicial")]
    partial class MigracionInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Facturacion_web_api.Models.AgenteViaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdDireccion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdDireccion");

                    b.ToTable("AgenteViaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.Alojamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreHotel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("TipoHabitacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Alojamiento");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdDireccion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdDireccion");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.ComentariosYValoraciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdPaquete")
                        .HasColumnType("int");

                    b.Property<int>("IdViaje")
                        .HasColumnType("int");

                    b.Property<float>("Valoracion")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdPaquete");

                    b.HasIndex("IdViaje");

                    b.ToTable("ComentariosYValoraciones");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.DetallePaquete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescripcionPaquete")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DuracionViaje")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdPaqueteViaje")
                        .HasColumnType("int");

                    b.Property<int>("IdSerivicioViaje")
                        .HasColumnType("int");

                    b.Property<int>("IdViaje")
                        .HasColumnType("int");

                    b.Property<string>("NombrePaquete")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdPaqueteViaje");

                    b.HasIndex("IdSerivicioViaje");

                    b.HasIndex("IdViaje");

                    b.ToTable("DetallePaquete");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.DetalleReserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<int>("IdViaje")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdFactura");

                    b.HasIndex("IdReserva");

                    b.HasIndex("IdViaje");

                    b.ToTable("DetalleReserva");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.DetalleTransporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdTransporte")
                        .HasColumnType("int");

                    b.Property<int>("IdViaje")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTransporte");

                    b.HasIndex("IdViaje");

                    b.ToTable("DetalleTransporte");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.DetalleViaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DuracionViaje")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdAlojamiento")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdTransporte")
                        .HasColumnType("int");

                    b.Property<int>("IdViaje")
                        .HasColumnType("int");

                    b.Property<float>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("idPaqueteViaje")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAlojamiento");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdTransporte");

                    b.HasIndex("IdViaje");

                    b.HasIndex("idPaqueteViaje");

                    b.ToTable("DetalleViaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Provincia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Direccion");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.EstadoReserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdReserva");

                    b.ToTable("EstadoReserva");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MetodoPago")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("MontoPagado")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.PaqueteViaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescripcionPaquete")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Duracionviaje")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NombrePaquete")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("PaqueteViaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.ProveedorServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NombreProveedor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TipoServicio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ProveedorServicio");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EstadoReserva")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FinFechaReserva")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("InicioFechaReserva")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.SercicioViaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdProveedor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdProveedor");

                    b.ToTable("SercicioViaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.Transporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Itiner")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TipoTransporte")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Transporte");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.Viaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DuracionViaje")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Viaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.AgenteViaje", b =>
                {
                    b.HasOne("Facturacion_web_api.Models.Direccion", "Direccion")
                        .WithMany()
                        .HasForeignKey("IdDireccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direccion");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.Cliente", b =>
                {
                    b.HasOne("Facturacion_web_api.Models.Direccion", "Direccion")
                        .WithMany()
                        .HasForeignKey("IdDireccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direccion");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.ComentariosYValoraciones", b =>
                {
                    b.HasOne("Facturacion_web_api.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.PaqueteViaje", "PaqueteViaje")
                        .WithMany()
                        .HasForeignKey("IdPaquete")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.Viaje", "Viaje")
                        .WithMany()
                        .HasForeignKey("IdViaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("PaqueteViaje");

                    b.Navigation("Viaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.DetallePaquete", b =>
                {
                    b.HasOne("Facturacion_web_api.Models.PaqueteViaje", "PaqueteViaje")
                        .WithMany()
                        .HasForeignKey("IdPaqueteViaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.SercicioViaje", "SercicioViaje")
                        .WithMany()
                        .HasForeignKey("IdSerivicioViaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.Viaje", "Viaje")
                        .WithMany()
                        .HasForeignKey("IdViaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaqueteViaje");

                    b.Navigation("SercicioViaje");

                    b.Navigation("Viaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.DetalleReserva", b =>
                {
                    b.HasOne("Facturacion_web_api.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("IdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("IdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.Viaje", "Viaje")
                        .WithMany()
                        .HasForeignKey("IdViaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Factura");

                    b.Navigation("Reserva");

                    b.Navigation("Viaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.DetalleTransporte", b =>
                {
                    b.HasOne("Facturacion_web_api.Models.Transporte", "Transporte")
                        .WithMany()
                        .HasForeignKey("IdTransporte")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.Viaje", "Viaje")
                        .WithMany()
                        .HasForeignKey("IdViaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Transporte");

                    b.Navigation("Viaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.DetalleViaje", b =>
                {
                    b.HasOne("Facturacion_web_api.Models.Alojamiento", "Alojamiento")
                        .WithMany()
                        .HasForeignKey("IdAlojamiento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.Transporte", "Transporte")
                        .WithMany()
                        .HasForeignKey("IdTransporte")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.Viaje", "Viaje")
                        .WithMany()
                        .HasForeignKey("IdViaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Facturacion_web_api.Models.PaqueteViaje", "PaqueteViaje")
                        .WithMany()
                        .HasForeignKey("idPaqueteViaje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alojamiento");

                    b.Navigation("Cliente");

                    b.Navigation("PaqueteViaje");

                    b.Navigation("Transporte");

                    b.Navigation("Viaje");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.EstadoReserva", b =>
                {
                    b.HasOne("Facturacion_web_api.Models.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("IdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("Facturacion_web_api.Models.SercicioViaje", b =>
                {
                    b.HasOne("Facturacion_web_api.Models.ProveedorServicio", "ProveedorServicio")
                        .WithMany()
                        .HasForeignKey("IdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProveedorServicio");
                });
#pragma warning restore 612, 618
        }
    }
}
