using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitMigratio4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_PayRollType_PayRollTypeId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_PayRollTypeId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PayRollTypeId",
                table: "Player");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PayRollTypeId",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Player_PayRollTypeId",
                table: "Player",
                column: "PayRollTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_PayRollType_PayRollTypeId",
                table: "Player",
                column: "PayRollTypeId",
                principalTable: "PayRollType",
                principalColumn: "Id");
        }
    }
}
