using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "PlayerPosition",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPosition_PlayerId",
                table: "PlayerPosition",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_Player_PlayerId",
                table: "PlayerPosition",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_Player_PlayerId",
                table: "PlayerPosition");

            migrationBuilder.DropIndex(
                name: "IX_PlayerPosition_PlayerId",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayerPosition");
        }
    }
}
