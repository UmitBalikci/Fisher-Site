using Microsoft.EntityFrameworkCore.Migrations;

namespace FisherSite.Persistence.Migrations
{
    public partial class PersonHasDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Persons",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityNumber",
                table: "Persons",
                type: "char(11)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Persons",
                type: "char(11)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VehicleInfo",
                table: "Persons",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "IdentityNumber", "Phone", "VehicleInfo" },
                values: new object[] { "ademir@gmail.com", "10101010101", "05301234560", "34AB1234" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "IdentityNumber", "Phone", "VehicleInfo" },
                values: new object[] { "ebal@gmail.com", "10101010102", "05301234561", "YOK" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "IdentityNumber", "Phone", "VehicleInfo" },
                values: new object[] { "mkugu@gmail.com", "10101010103", "05301234562", "34CDF34" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "IdentityNumber", "Phone", "VehicleInfo" },
                values: new object[] { "zkuyu@gmail.com", "10101010104", "05301234563", "34KL9834" });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "IdentityNumber", "Phone", "VehicleInfo" },
                values: new object[] { "defe@gmail.com", "10101010105", "05301234564", "34RB234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "VehicleInfo",
                table: "Persons");
        }
    }
}
