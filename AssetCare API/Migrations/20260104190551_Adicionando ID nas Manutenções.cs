using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetCare_API.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoIDnasManutenções : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EquipmentoId",
                table: "Manutencoes",
                newName: "MaquinaId");

            migrationBuilder.AlterColumn<string>(
                name: "TecnicoId",
                table: "Manutencoes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencoes_MaquinaId",
                table: "Manutencoes",
                column: "MaquinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencoes_TecnicoId",
                table: "Manutencoes",
                column: "TecnicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencoes_Maquinas_MaquinaId",
                table: "Manutencoes",
                column: "MaquinaId",
                principalTable: "Maquinas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencoes_Tecnicos_TecnicoId",
                table: "Manutencoes",
                column: "TecnicoId",
                principalTable: "Tecnicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manutencoes_Maquinas_MaquinaId",
                table: "Manutencoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencoes_Tecnicos_TecnicoId",
                table: "Manutencoes");

            migrationBuilder.DropIndex(
                name: "IX_Manutencoes_MaquinaId",
                table: "Manutencoes");

            migrationBuilder.DropIndex(
                name: "IX_Manutencoes_TecnicoId",
                table: "Manutencoes");

            migrationBuilder.RenameColumn(
                name: "MaquinaId",
                table: "Manutencoes",
                newName: "EquipmentoId");

            migrationBuilder.AlterColumn<int>(
                name: "TecnicoId",
                table: "Manutencoes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
