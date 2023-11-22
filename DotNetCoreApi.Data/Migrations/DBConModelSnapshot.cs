﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DotNetCoreApi.Data.Context;

#nullable disable

namespace DotNetCoreApi.Data.Migrations
{
    [DbContext(typeof(DBCon))]
    partial class DBConModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DotNetCoreApi.Model.EmployeeMasterModel", b =>
                {
                    b.Property<int>("EmployeeMasterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeMasterID"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeMasterDeleted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmployeeMasterUpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeMasterUserUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavourite")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeMasterID");

                    b.ToTable("EmployeeMaster", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
