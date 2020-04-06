using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentManager.Migrations
{
    public partial class InitialCOmmit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    FullName = table.Column<string>(unicode: false, maxLength: 40, nullable: false, computedColumnSql: "(concat([FirstName],[LastName]))"),
                    LastName = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 49, nullable: false, computedColumnSql: "(concat([FirstName],[LastName]+'@ucwv.edu'))"),
                    ColleaugeId = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipType = table.Column<string>(maxLength: 200, nullable: false),
                    Vendor = table.Column<string>(maxLength: 200, nullable: false),
                    Manufacturer = table.Column<string>(maxLength: 250, nullable: false),
                    Model = table.Column<string>(maxLength: 150, nullable: false),
                    SubModel = table.Column<string>(maxLength: 50, nullable: true),
                    SerialNum = table.Column<string>(maxLength: 50, nullable: false),
                    ServiceTag = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceNum = table.Column<string>(maxLength: 25, nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime", nullable: false),
                    RequestingDept = table.Column<string>(maxLength: 200, nullable: false),
                    RequestedBy = table.Column<string>(maxLength: 250, nullable: false),
                    Warranty = table.Column<bool>(nullable: true),
                    DecommissionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DecommissionStatus = table.Column<bool>(nullable: true),
                    DestroyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DestroyStatus = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Repair",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(nullable: false),
                    RequestedBy = table.Column<string>(maxLength: 100, nullable: false),
                    RmaNum = table.Column<string>(maxLength: 100, nullable: false),
                    DateShipped = table.Column<DateTime>(type: "date", nullable: false),
                    TrackingNum = table.Column<string>(maxLength: 100, nullable: false),
                    Recipient = table.Column<string>(maxLength: 100, nullable: false),
                    StreetAddress1 = table.Column<string>(maxLength: 200, nullable: false),
                    StreetAddress2 = table.Column<string>(maxLength: 100, nullable: true),
                    StreetAddress3 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    Zip = table.Column<string>(maxLength: 10, nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    ContactEmail = table.Column<string>(maxLength: 100, nullable: true),
                    ContactPhone = table.Column<string>(maxLength: 100, nullable: true),
                    ReplacementSerialNumber = table.Column<string>(maxLength: 100, nullable: true),
                    Returned = table.Column<bool>(nullable: true),
                    DateReturned = table.Column<DateTime>(type: "date", nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repair", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Abbreviation = table.Column<string>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColleagueId = table.Column<string>(nullable: false),
                    EquipmentId = table.Column<int>(nullable: false),
                    RequestingDepartment = table.Column<string>(nullable: false),
                    AssignedBy = table.Column<string>(nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UnassignedBy = table.Column<int>(nullable: true),
                    UnassignedDate = table.Column<DateTime>(type: "date", nullable: true),
                    Location = table.Column<string>(nullable: true),
                    RoomNumber = table.Column<int>(nullable: true),
                    Floor = table.Column<int>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignment_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_DepartmentId",
                table: "Assignment",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "EquipmentType");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropTable(
                name: "Repair");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
