using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capaEF.Migrations
{
    /// <inheritdoc />
    public partial class updateComandaParametro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoDePago",
                table: "Comanda",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoDePago",
                table: "Comanda");
        }
    }
}
