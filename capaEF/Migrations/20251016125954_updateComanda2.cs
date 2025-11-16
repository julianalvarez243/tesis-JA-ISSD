using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capaEF.Migrations
{
    /// <inheritdoc />
    public partial class updateComanda2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_Bebida_BebidaId",
                table: "Comanda");

            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_Comida_ComidaId",
                table: "Comanda");

            migrationBuilder.DropIndex(
                name: "IX_Comanda_BebidaId",
                table: "Comanda");

            migrationBuilder.DropIndex(
                name: "IX_Comanda_ComidaId",
                table: "Comanda");

            migrationBuilder.DropColumn(
                name: "BebidaId",
                table: "Comanda");

            migrationBuilder.DropColumn(
                name: "ComidaId",
                table: "Comanda");

            migrationBuilder.CreateTable(
                name: "ComandaDetalle",
                columns: table => new
                {
                    ComandaDetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComandaId = table.Column<int>(type: "int", nullable: false),
                    ComidaId = table.Column<int>(type: "int", nullable: true),
                    BebidaId = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandaDetalle", x => x.ComandaDetalleId);
                    table.ForeignKey(
                        name: "FK_ComandaDetalle_Bebida_BebidaId",
                        column: x => x.BebidaId,
                        principalTable: "Bebida",
                        principalColumn: "BebidaId");
                    table.ForeignKey(
                        name: "FK_ComandaDetalle_Comanda_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comanda",
                        principalColumn: "ComandaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComandaDetalle_Comida_ComidaId",
                        column: x => x.ComidaId,
                        principalTable: "Comida",
                        principalColumn: "ComidaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComandaDetalle_BebidaId",
                table: "ComandaDetalle",
                column: "BebidaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaDetalle_ComandaId",
                table: "ComandaDetalle",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaDetalle_ComidaId",
                table: "ComandaDetalle",
                column: "ComidaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComandaDetalle");

            migrationBuilder.AddColumn<int>(
                name: "BebidaId",
                table: "Comanda",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComidaId",
                table: "Comanda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_BebidaId",
                table: "Comanda",
                column: "BebidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_ComidaId",
                table: "Comanda",
                column: "ComidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_Bebida_BebidaId",
                table: "Comanda",
                column: "BebidaId",
                principalTable: "Bebida",
                principalColumn: "BebidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_Comida_ComidaId",
                table: "Comanda",
                column: "ComidaId",
                principalTable: "Comida",
                principalColumn: "ComidaId");
        }
    }
}
