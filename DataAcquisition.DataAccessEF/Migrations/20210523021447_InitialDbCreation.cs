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
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    FacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.FacilityId);
                    table.ForeignKey(
                        name: "FK_Facility_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Email);
                    table.ForeignKey(
                        name: "FK_User_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workstation",
                columns: table => new
                {
                    WorkstationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkstationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConnectionProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkstationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    ExperimentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExperimentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperimentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkstationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiment", x => x.ExperimentId);
                    table.ForeignKey(
                        name: "FK_Experiment_User_UserEmail",
                        column: x => x.UserEmail,
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
                values: new object[] { "DataAcquisition", new DateTime(2021, 5, 23, 3, 14, 47, 282, DateTimeKind.Local).AddTicks(3267), new DateTime(2021, 5, 23, 3, 14, 47, 284, DateTimeKind.Local).AddTicks(5739), "1.0.0" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[] { new Guid("c32da8dc-7fa4-4030-860e-17476af61820"), "AcmeCompany" });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "FacilityId", "CompanyId", "FacilityName" },
                values: new object[] { new Guid("6d529ae9-8574-4099-a428-a31b8b61114f"), new Guid("c32da8dc-7fa4-4030-860e-17476af61820"), "FacilityA" });

            migrationBuilder.InsertData(
                table: "Facility",
                columns: new[] { "FacilityId", "CompanyId", "FacilityName" },
                values: new object[] { new Guid("626a363d-f786-4012-8357-c3d27d436264"), new Guid("c32da8dc-7fa4-4030-860e-17476af61820"), "FacilityB" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Email", "CompanyId", "LastLogin", "Name", "Password", "Surname" },
                values: new object[] { "muratistipliler@gmail.com", new Guid("c32da8dc-7fa4-4030-860e-17476af61820"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Murat", "25d55ad283aa400af464c76d713c07ad", "Istipliler" });

            migrationBuilder.CreateIndex(
                name: "IX_Device_WorkstationId",
                table: "Device",
                column: "WorkstationId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiment_UserEmail",
                table: "Experiment",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Experiment_WorkstationId",
                table: "Experiment",
                column: "WorkstationId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_CompanyId",
                table: "Facility",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyId",
                table: "User",
                column: "CompanyId");

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
