using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialM2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_Person_PersonId",
                table: "PlayerPosition");

            migrationBuilder.DropIndex(
                name: "IX_PlayerPosition_PersonId",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "PlayerPosition");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "PlayerPosition",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPosition_PersonId",
                table: "PlayerPosition",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_Person_PersonId",
                table: "PlayerPosition",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }
    }
}
