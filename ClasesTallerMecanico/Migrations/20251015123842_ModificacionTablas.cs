using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesTallerMecanico.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Turnos");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Turnos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IdLocalidad",
                table: "Turnos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_IdLocalidad",
                table: "Turnos",
                column: "IdLocalidad");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Localidades_IdLocalidad",
                table: "Turnos",
                column: "IdLocalidad",
                principalTable: "Localidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Localidades_IdLocalidad",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_IdLocalidad",
                table: "Turnos");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Turnos");

            migrationBuilder.DropColumn(
                name: "IdLocalidad",
                table: "Turnos");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Turnos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
