using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitMigratio3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_Player_PlayerId",
                table: "PlayerPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_Position_PositionId",
                table: "PlayerPosition");

            migrationBuilder.DropIndex(
                name: "IX_PlayerPosition_PlayerId",
                table: "PlayerPosition");

            migrationBuilder.DropIndex(
                name: "IX_PlayerPosition_PositionId",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "PlayerPosition");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "PlayerPosition",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "PlayerPosition",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPosition_PlayerId",
                table: "PlayerPosition",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPosition_PositionId",
                table: "PlayerPosition",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_Player_PlayerId",
                table: "PlayerPosition",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_Position_PositionId",
                table: "PlayerPosition",
                column: "PositionId",
                principalTable: "Position",
                principalColumn: "Id");
        }
    }
}
