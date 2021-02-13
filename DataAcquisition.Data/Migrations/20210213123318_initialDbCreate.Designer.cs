﻿// <auto-generated />
using System;
using DataAcquisition.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAcquisition.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210213123318_initialDbCreate")]
    partial class initialDbCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.ApplicationInfo", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FirstInstallDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("ApplicationInfo");

                    b.HasData(
                        new
                        {
                            Name = "DataAcquisition",
                            FirstInstallDateTime = new DateTime(2021, 2, 13, 12, 33, 18, 24, DateTimeKind.Local).AddTicks(2017),
                            LastUpdateDateTime = new DateTime(2021, 2, 13, 12, 33, 18, 26, DateTimeKind.Local).AddTicks(2209),
                            Version = "1.0.0"
                        });
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Company", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Experiment", b =>
                {
                    b.Property<Guid>("ExperimentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExperimentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("WorkStationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ExperimentId");

                    b.HasIndex("WorkStationId");

                    b.ToTable("Experiments");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Facility", b =>
                {
                    b.Property<Guid>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FacilityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Workstation", b =>
                {
                    b.Property<Guid>("WorkStationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FacilityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WorkStationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkStationId");

                    b.HasIndex("FacilityId");

                    b.ToTable("Workstations");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Experiment", b =>
                {
                    b.HasOne("DataAcquisition.Core.Models.Entities.Workstation", "WorkStation")
                        .WithMany("Experiments")
                        .HasForeignKey("WorkStationId");

                    b.Navigation("WorkStation");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Facility", b =>
                {
                    b.HasOne("DataAcquisition.Core.Models.Entities.Company", "Company")
                        .WithMany("Facilities")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.User", b =>
                {
                    b.HasOne("DataAcquisition.Core.Models.Entities.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Workstation", b =>
                {
                    b.HasOne("DataAcquisition.Core.Models.Entities.Facility", "Facility")
                        .WithMany("WorkStations")
                        .HasForeignKey("FacilityId");

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Company", b =>
                {
                    b.Navigation("Facilities");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Facility", b =>
                {
                    b.Navigation("WorkStations");
                });

            modelBuilder.Entity("DataAcquisition.Core.Models.Entities.Workstation", b =>
                {
                    b.Navigation("Experiments");
                });
#pragma warning restore 612, 618
        }
    }
}
