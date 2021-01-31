using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicTheGatheringRazor.Migrations
{
    public partial class sqlite_initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Rarity = table.Column<int>(type: "INTEGER", nullable: false),
                    Set_Name = table.Column<string>(type: "TEXT", nullable: false),
                    Power = table.Column<int>(type: "INTEGER", nullable: true),
                    Toughness = table.Column<int>(type: "INTEGER", nullable: true),
                    Rules_Text = table.Column<string>(type: "TEXT", nullable: true),
                    Number_in_Set = table.Column<int>(type: "INTEGER", nullable: true),
                    Set_Size = table.Column<int>(type: "INTEGER", nullable: true),
                    FlavorText = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardTypeList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Card_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    CardsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardTypeList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardTypeList_cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ManaColorList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Card_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    ManaColor = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false),
                    CardsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManaColorList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManaColorList_cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubTypeList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Card_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    SubType = table.Column<int>(type: "INTEGER", nullable: false),
                    CardsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTypeList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTypeList_cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "supertypelist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Card_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CardsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supertypelist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_supertypelist_cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardTypeList_CardsId",
                table: "CardTypeList",
                column: "CardsId");

            migrationBuilder.CreateIndex(
                name: "IX_ManaColorList_CardsId",
                table: "ManaColorList",
                column: "CardsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTypeList_CardsId",
                table: "SubTypeList",
                column: "CardsId");

            migrationBuilder.CreateIndex(
                name: "IX_supertypelist_CardsId",
                table: "supertypelist",
                column: "CardsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardTypeList");

            migrationBuilder.DropTable(
                name: "ManaColorList");

            migrationBuilder.DropTable(
                name: "SubTypeList");

            migrationBuilder.DropTable(
                name: "supertypelist");

            migrationBuilder.DropTable(
                name: "cards");
        }
    }
}
