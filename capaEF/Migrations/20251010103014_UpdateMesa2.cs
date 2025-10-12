using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capaEF.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMesa2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponibile",
                table: "Mesa");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Mesa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Mesa");

            migrationBuilder.AddColumn<bool>(
                name: "Disponibile",
                table: "Mesa",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
