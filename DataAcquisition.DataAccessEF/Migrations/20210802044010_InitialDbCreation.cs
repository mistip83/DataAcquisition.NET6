using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcquisition.DataAccessEF.Migrations
{
    public partial class InitialDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationInfo",
                columns: table => new
                {
                    ApplicationName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstInstallDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationInfo", x => x.ApplicationName);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyName);
                });

            migrationBuilder.CreateTable(
                name: "ExperimentData",
                columns: table => new
                {
                    ExperimentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChannelNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChannelUnits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperimentData", x => x.ExperimentId);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Employees = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.FacilityId);
                    table.ForeignKey(
                        name: "FK_Facility_Company_CompanyName",
                        column: x => x.CompanyName,
                        principalTable: "Company",
                        principalColumn: "CompanyName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true, computedColumnSql: "[Name] + ', ' + [Surname]"),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Email);
                    table.ForeignKey(
                        name: "FK_User_Company_CompanyName",
                        column: x => x.CompanyName,
                        principalTable: "Company",
                        principalColumn: "CompanyName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workstation",
                columns: table => new
                {
                    WorkstationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkstationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkstationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workstation", x => x.WorkstationId);
                    table.ForeignKey(
                        name: "FK_Workstation_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    DeviceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeviceType = table.Column<int>(type: "int", nullable: false),
                    ConnectionType = table.Column<int>(type: "int", nullable: false),
                    WorkstationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.DeviceId);
                    table.ForeignKey(
                        name: "FK_Device_Workstation_WorkstationId",
                        column: x => x.WorkstationId,
                        principalTable: "Workstation",
                        principalColumn: "WorkstationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiment",
                columns: table => new
                {
                    ExperimentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperimentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExperimentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperimentDataId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkstationId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiment", x => x.ExperimentId);
                    table.ForeignKey(
                        name: "FK_Experiment_User_Email",
                        column: x => x.Email,
                        principalTable: "User",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Experiment_Workstation_WorkstationId",
                        column: x => x.WorkstationId,
                        principalTable: "Workstation",
                        principalColumn: "WorkstationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationInfo",
                columns: new[] { "ApplicationName", "FirstInstallDate", "LastUpdateDate", "Version" },
                values: new object[] { "DataAcquisition", new DateTime(2021, 8, 2, 7, 40, 10, 72, DateTimeKind.Local).AddTicks(8015), new DateTime(2021, 7, 2, 7, 40, 10, 73, DateTimeKind.Local).AddTicks(7475), "1.0.0" });

            migrationBuilder.InsertData(
                table: "Company",
                column: "CompanyName",
                value: "AcmeCompany");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Email", "CompanyName", "LastLogin", "Name", "Password", "Surname" },
                values: new object[] { "muratistipliler@gmail.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Murat", "25d55ad283aa400af464c76d713c07ad", "Istip" });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "FacilityId", "Address", "CompanyName", "Employees", "FacilityName" },
                values: new object[] { 1, "V94 H9FF - Limerick", "AcmeCompany", 65, "FacilityA" });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "FacilityId", "Address", "CompanyName", "Employees", "FacilityName" },
                values: new object[] { 2, "V35 S7BN - Cork", "AcmeCompany", 140, "FacilityB" });

            migrationBuilder.InsertData(
                table: "Workstation",
                columns: new[] { "WorkstationId", "FacilityId", "IsDeleted", "WorkstationDescription", "WorkstationName" },
                values: new object[,]
                {
                    { 1, 1, false, "Lab4", "Workstation1" },
                    { 2, 1, false, "Lab4", "Workstation2" },
                    { 3, 1, false, "Lab7", "Workstation3" },
                    { 4, 2, false, "ProductionLine", "Workstation4" },
                    { 5, 2, false, "ProductionLine", "Workstation5" }
                });

            migrationBuilder.InsertData(
                table: "Device",
                columns: new[] { "DeviceId", "ConnectionType", "DeviceName", "DeviceType", "WorkstationId" },
                values: new object[,]
                {
                    { 1, 1, "DAQ1", 1, 1 },
                    { 2, 1, "NetworkAnalyzer1", 4, 1 },
                    { 3, 2, "EnergyAnalyzer1", 2, 1 },
                    { 4, 2, "EnergyAnalyzer2", 2, 1 },
                    { 5, 3, "DigitalMultimeter1", 3, 1 },
                    { 6, 3, "DigitalMultimeter2", 3, 1 },
                    { 7, 3, "DigitalMultimeter3", 3, 1 },
                    { 8, 1, "DAQ1", 1, 2 },
                    { 9, 1, "DAQ2", 1, 2 },
                    { 10, 2, "EnergyAnalyzer1", 2, 3 },
                    { 11, 3, "DigitalMultimeter1", 3, 4 },
                    { 12, 3, "DigitalMultimeter2", 3, 4 },
                    { 14, 3, "DigitalMultimeter1", 3, 4 },
                    { 15, 3, "DigitalMultimeter2", 3, 4 },
                    { 13, 2, "EnergyAnalyzer1", 2, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Device_WorkstationId",
                table: "Device",
                column: "WorkstationId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiment_Email",
                table: "Experiment",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Experiment_WorkstationId",
                table: "Experiment",
                column: "WorkstationId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_CompanyName",
                table: "Facility",
                column: "CompanyName");

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyName",
                table: "User",
                column: "CompanyName");

            migrationBuilder.CreateIndex(
                name: "IX_Workstation_FacilityId",
                table: "Workstation",
                column: "FacilityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationInfo");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Experiment");

            migrationBuilder.DropTable(
                name: "ExperimentData");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Workstation");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
