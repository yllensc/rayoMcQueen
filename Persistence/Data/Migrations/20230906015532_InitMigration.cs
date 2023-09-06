using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameCountry = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PayRollType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameType = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayRollType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamePosition = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameTeam = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FKIdCountry = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Country_FKIdCountry",
                        column: x => x.FKIdCountry,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FKIdPerson = table.Column<int>(type: "int", nullable: false),
                    Dorsal = table.Column<int>(type: "int", nullable: false),
                    PayRollTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_PayRollType_PayRollTypeId",
                        column: x => x.PayRollTypeId,
                        principalTable: "PayRollType",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstNamePerson = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastNamePerson = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AgePerson = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FKIdPayRollType = table.Column<int>(type: "int", nullable: false),
                    FKIdTeam = table.Column<int>(type: "int", nullable: false),
                    FKIdPlayer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_PayRollType_FKIdPayRollType",
                        column: x => x.FKIdPayRollType,
                        principalTable: "PayRollType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Player_FKIdPlayer",
                        column: x => x.FKIdPlayer,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Team_FKIdTeam",
                        column: x => x.FKIdTeam,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlayerPosition",
                columns: table => new
                {
                    FKIdPlayer = table.Column<int>(type: "int", nullable: false),
                    FKIdPosition = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPosition", x => new { x.FKIdPlayer, x.FKIdPosition });
                    table.ForeignKey(
                        name: "FK_PlayerPosition_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayerPosition_Player_FKIdPlayer",
                        column: x => x.FKIdPlayer,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerPosition_Position_FKIdPosition",
                        column: x => x.FKIdPosition,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerPosition_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Country_NameCountry",
                table: "Country",
                column: "NameCountry",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PayRollType_NameType",
                table: "PayRollType",
                column: "NameType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_FKIdPayRollType",
                table: "Person",
                column: "FKIdPayRollType");

            migrationBuilder.CreateIndex(
                name: "IX_Person_FKIdPlayer",
                table: "Person",
                column: "FKIdPlayer",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_FKIdTeam",
                table: "Person",
                column: "FKIdTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Player_PayRollTypeId",
                table: "Player",
                column: "PayRollTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPosition_FKIdPosition",
                table: "PlayerPosition",
                column: "FKIdPosition");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPosition_PersonId",
                table: "PlayerPosition",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPosition_PositionId",
                table: "PlayerPosition",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_NamePosition",
                table: "Position",
                column: "NamePosition",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Team_FKIdCountry",
                table: "Team",
                column: "FKIdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_Team_NameTeam",
                table: "Team",
                column: "NameTeam",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerPosition");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "PayRollType");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
