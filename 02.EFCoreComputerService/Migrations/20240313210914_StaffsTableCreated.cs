using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02.EFCoreComputerService.Migrations
{
    /// <inheritdoc />
    public partial class StaffsTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "ServiceRecords",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_StaffId",
                table: "ServiceRecords",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Staffs_StaffId",
                table: "ServiceRecords",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Staffs_StaffId",
                table: "ServiceRecords");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRecords_StaffId",
                table: "ServiceRecords");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "ServiceRecords");
        }
    }
}
