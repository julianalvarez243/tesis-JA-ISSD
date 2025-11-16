using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capaEF.Migrations
{
    /// <inheritdoc />
    public partial class updateComanda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaHora",
                table: "Comanda",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaHora",
                table: "Comanda");

            migrationBuilder.AddColumn<int>(
                name: "EstadoMesaId",
                table: "Mesa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EstadoMesa",
                columns: table => new
                {
                    EstadoMesaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoMesa", x => x.EstadoMesaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mesa_EstadoMesaId",
                table: "Mesa",
                column: "EstadoMesaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mesa_EstadoMesa_EstadoMesaId",
                table: "Mesa",
                column: "EstadoMesaId",
                principalTable: "EstadoMesa",
                principalColumn: "EstadoMesaId");
        }
    }
}
