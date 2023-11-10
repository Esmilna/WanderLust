using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facturacion_web_api.Migrations
{
    /// <inheritdoc />
    public partial class SeAgregaronCambiosALaEntidadReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdViaje",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TelefonoCliente",
                table: "Reserva",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "cedulaCliente",
                table: "Reserva",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "nombreCliente",
                table: "Reserva",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdViaje",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "TelefonoCliente",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "cedulaCliente",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "nombreCliente",
                table: "Reserva");
        }
    }
}
