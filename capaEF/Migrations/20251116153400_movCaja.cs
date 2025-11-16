using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capaEF.Migrations
{
    /// <inheritdoc />
    public partial class movCaja : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caja_EstadoCaja_EstadoCajaId",
                table: "Caja");

            migrationBuilder.DropForeignKey(
                name: "FK_MovimientoCaja_Caja_CajaId",
                table: "MovimientoCaja");

            migrationBuilder.DropForeignKey(
                name: "FK_MovimientoCaja_Usuario_UsuarioId",
                table: "MovimientoCaja");

            migrationBuilder.DropTable(
                name: "EstadoCaja");

            migrationBuilder.DropIndex(
                name: "IX_MovimientoCaja_CajaId",
                table: "MovimientoCaja");

            migrationBuilder.DropIndex(
                name: "IX_MovimientoCaja_UsuarioId",
                table: "MovimientoCaja");

            migrationBuilder.DropIndex(
                name: "IX_Caja_EstadoCajaId",
                table: "Caja");

            migrationBuilder.RenameColumn(
                name: "CajaId",
                table: "MovimientoCaja",
                newName: "ComandaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComandaId",
                table: "MovimientoCaja",
                newName: "CajaId");

            migrationBuilder.CreateTable(
                name: "EstadoCaja",
                columns: table => new
                {
                    EstadoCajaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCaja", x => x.EstadoCajaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCaja_CajaId",
                table: "MovimientoCaja",
                column: "CajaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCaja_UsuarioId",
                table: "MovimientoCaja",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Caja_EstadoCajaId",
                table: "Caja",
                column: "EstadoCajaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caja_EstadoCaja_EstadoCajaId",
                table: "Caja",
                column: "EstadoCajaId",
                principalTable: "EstadoCaja",
                principalColumn: "EstadoCajaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovimientoCaja_Caja_CajaId",
                table: "MovimientoCaja",
                column: "CajaId",
                principalTable: "Caja",
                principalColumn: "CajaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovimientoCaja_Usuario_UsuarioId",
                table: "MovimientoCaja",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
