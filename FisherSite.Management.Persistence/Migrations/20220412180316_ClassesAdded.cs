using Microsoft.EntityFrameworkCore.Migrations;

namespace FisherSite.Persistence.Migrations
{
    public partial class ClassesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApartmentStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockId = table.Column<int>(type: "int", nullable: false),
                    ApartmentStateId = table.Column<int>(type: "int", nullable: false),
                    ApartmentTypeId = table.Column<int>(type: "int", nullable: false),
                    ApartmentFloor = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_ApartmentStates_ApartmentStateId",
                        column: x => x.ApartmentStateId,
                        principalTable: "ApartmentStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartments_ApartmentTypes_ApartmentTypeId",
                        column: x => x.ApartmentTypeId,
                        principalTable: "ApartmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartments_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartments_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ApartmentStates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Empty" },
                    { 2, "Full" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "1+1" },
                    { 2, "2+1" },
                    { 3, "3+1" },
                    { 4, "4+1" }
                });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A Block" },
                    { 2, "B Block" },
                    { 3, "C Block" },
                    { 4, "D Block" },
                    { 5, "E Block" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ahmet Demir" },
                    { 2, "Ece Bal" },
                    { 3, "Murat Kuğu" },
                    { 4, "Zeynep Kuyu" },
                    { 5, "Deniz Efe" }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "ApartmentFloor", "ApartmentStateId", "ApartmentTypeId", "BlockId", "PersonId" },
                values: new object[,]
                {
                    { 1, 5, 1, 1, 1, null },
                    { 2, 5, 1, 1, 1, null },
                    { 3, 5, 1, 1, 2, null },
                    { 4, 5, 2, 2, 2, 1 },
                    { 5, 5, 2, 2, 3, 2 },
                    { 6, 5, 2, 3, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentStateId",
                table: "Apartments",
                column: "ApartmentStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentTypeId",
                table: "Apartments",
                column: "ApartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_BlockId",
                table: "Apartments",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_PersonId",
                table: "Apartments",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "ApartmentStates");

            migrationBuilder.DropTable(
                name: "ApartmentTypes");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
