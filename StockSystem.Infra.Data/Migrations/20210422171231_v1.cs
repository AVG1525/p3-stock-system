using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace StockSystem.Infra.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "descriptionrawmaterial",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_descriptionrawmaterial", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "validationtestday",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    dateday = table.Column<DateTime>(nullable: false),
                    isholiday = table.Column<bool>(nullable: false),
                    growthrate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_validationtestday", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "establishment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(nullable: true),
                    iduser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_establishment", x => x.id);
                    table.ForeignKey(
                        name: "FK_establishment_user_iduser",
                        column: x => x.iduser,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rawmaterial",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    iddescriptionrawmaterial = table.Column<int>(nullable: false),
                    idestablishment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rawmaterial", x => x.id);
                    table.ForeignKey(
                        name: "FK_rawmaterial_descriptionrawmaterial_iddescriptionrawmaterial",
                        column: x => x.iddescriptionrawmaterial,
                        principalTable: "descriptionrawmaterial",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rawmaterial_establishment_idestablishment",
                        column: x => x.idestablishment,
                        principalTable: "establishment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saleday",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    dateday = table.Column<DateTime>(nullable: false),
                    resultday = table.Column<decimal>(nullable: false),
                    idestablishment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saleday", x => x.id);
                    table.ForeignKey(
                        name: "FK_saleday_establishment_idestablishment",
                        column: x => x.idestablishment,
                        principalTable: "establishment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "statisticsday",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    dateday = table.Column<DateTime>(nullable: false),
                    rawmaterialexpenditure = table.Column<decimal>(nullable: false),
                    growthrate = table.Column<int>(nullable: false),
                    idestablishment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statisticsday", x => x.id);
                    table.ForeignKey(
                        name: "FK_statisticsday_establishment_idestablishment",
                        column: x => x.idestablishment,
                        principalTable: "establishment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historyrawmaterial",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    dateday = table.Column<DateTime>(nullable: false),
                    datevalidity = table.Column<DateTime>(nullable: false),
                    amount = table.Column<int>(nullable: false),
                    unitprice = table.Column<decimal>(nullable: false),
                    idrawmaterial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historyrawmaterial", x => x.id);
                    table.ForeignKey(
                        name: "FK_historyrawmaterial_rawmaterial_idrawmaterial",
                        column: x => x.idrawmaterial,
                        principalTable: "rawmaterial",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "statisticsrawmaterial",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    dateday = table.Column<DateTime>(nullable: false),
                    estimatedstockdateempty = table.Column<DateTime>(nullable: false),
                    idrawmaterial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statisticsrawmaterial", x => x.id);
                    table.ForeignKey(
                        name: "FK_statisticsrawmaterial_rawmaterial_idrawmaterial",
                        column: x => x.idrawmaterial,
                        principalTable: "rawmaterial",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_establishment_iduser",
                table: "establishment",
                column: "iduser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_historyrawmaterial_idrawmaterial",
                table: "historyrawmaterial",
                column: "idrawmaterial",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_rawmaterial_iddescriptionrawmaterial",
                table: "rawmaterial",
                column: "iddescriptionrawmaterial",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_rawmaterial_idestablishment",
                table: "rawmaterial",
                column: "idestablishment",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_saleday_idestablishment",
                table: "saleday",
                column: "idestablishment",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_statisticsday_idestablishment",
                table: "statisticsday",
                column: "idestablishment",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_statisticsrawmaterial_idrawmaterial",
                table: "statisticsrawmaterial",
                column: "idrawmaterial",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historyrawmaterial");

            migrationBuilder.DropTable(
                name: "saleday");

            migrationBuilder.DropTable(
                name: "statisticsday");

            migrationBuilder.DropTable(
                name: "statisticsrawmaterial");

            migrationBuilder.DropTable(
                name: "validationtestday");

            migrationBuilder.DropTable(
                name: "rawmaterial");

            migrationBuilder.DropTable(
                name: "descriptionrawmaterial");

            migrationBuilder.DropTable(
                name: "establishment");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
