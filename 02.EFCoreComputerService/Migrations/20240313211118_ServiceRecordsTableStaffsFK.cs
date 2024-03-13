using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02.EFCoreComputerService.Migrations
{
    /// <inheritdoc />
    public partial class ServiceRecordsTableStaffsFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Staffs_StaffId",
                table: "ServiceRecords");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRecords_StaffId",
                table: "ServiceRecords");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "ServiceRecords");

            migrationBuilder.CreateTable(
                name: "ServiceRecordStaff",
                columns: table => new
                {
                    ServiceRecordsId = table.Column<int>(type: "int", nullable: false),
                    StaffsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRecordStaff", x => new { x.ServiceRecordsId, x.StaffsId });
                    table.ForeignKey(
                        name: "FK_ServiceRecordStaff_ServiceRecords_ServiceRecordsId",
                        column: x => x.ServiceRecordsId,
                        principalTable: "ServiceRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRecordStaff_Staffs_StaffsId",
                        column: x => x.StaffsId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecordStaff_StaffsId",
                table: "ServiceRecordStaff",
                column: "StaffsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceRecordStaff");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "ServiceRecords",
                type: "int",
                nullable: true);

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
    }
}
