﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hrpayrollwebapi.Data;

#nullable disable

namespace hrpayrollwebapi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hrpayrollwebapi.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BasicSalary = 50000m,
                            FullName = "Tarif Hossain",
                            HireDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Position = "Manager"
                        },
                        new
                        {
                            EmployeeId = 2,
                            BasicSalary = 40000m,
                            FullName = "Ashraf Uddin",
                            HireDate = new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Position = "Developer"
                        },
                        new
                        {
                            EmployeeId = 3,
                            BasicSalary = 35000m,
                            FullName = "Abul Bashar Emon",
                            HireDate = new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Position = "HR Officer"
                        },
                        new
                        {
                            EmployeeId = 4,
                            BasicSalary = 37000m,
                            FullName = "Ahsanul Kabir",
                            HireDate = new DateTime(2022, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Position = "Accountant"
                        },
                        new
                        {
                            EmployeeId = 5,
                            BasicSalary = 42000m,
                            FullName = "Abdur Rahim",
                            HireDate = new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Position = "Sales Executive"
                        });
                });

            modelBuilder.Entity("hrpayrollwebapi.Models.PayrollDetails", b =>
                {
                    b.Property<int>("PayrollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PayrollId"));

                    b.Property<decimal>("Deductions")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("GrossSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NetSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PayMonth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PayrollId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("PayrollDetails");

                    b.HasData(
                        new
                        {
                            PayrollId = 1,
                            Deductions = 2000m,
                            EmployeeId = 1,
                            GrossSalary = 52000m,
                            NetSalary = 50000m,
                            PayMonth = "December 2024"
                        },
                        new
                        {
                            PayrollId = 2,
                            Deductions = 2000m,
                            EmployeeId = 2,
                            GrossSalary = 42000m,
                            NetSalary = 40000m,
                            PayMonth = "December 2024"
                        },
                        new
                        {
                            PayrollId = 3,
                            Deductions = 2000m,
                            EmployeeId = 3,
                            GrossSalary = 37000m,
                            NetSalary = 35000m,
                            PayMonth = "December 2024"
                        },
                        new
                        {
                            PayrollId = 4,
                            Deductions = 2000m,
                            EmployeeId = 4,
                            GrossSalary = 39000m,
                            NetSalary = 37000m,
                            PayMonth = "December 2024"
                        },
                        new
                        {
                            PayrollId = 5,
                            Deductions = 2000m,
                            EmployeeId = 5,
                            GrossSalary = 44000m,
                            NetSalary = 42000m,
                            PayMonth = "December 2024"
                        });
                });

            modelBuilder.Entity("hrpayrollwebapi.Models.PayrollDetails", b =>
                {
                    b.HasOne("hrpayrollwebapi.Models.Employee", "Employee")
                        .WithMany("PayrollDetails")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("hrpayrollwebapi.Models.Employee", b =>
                {
                    b.Navigation("PayrollDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
