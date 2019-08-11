﻿// <auto-generated />
using System;
using BookingSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingSystem.Infrastructure.Data.Migrations
{
    [DbContext(typeof(BookingSystemContext))]
    partial class BookingSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("BookingSystem.BuisnessLogic.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerId");

                    b.Property<int?>("CustomerId1");

                    b.Property<string>("EmployeeId");

                    b.Property<int?>("EmployeeId1");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId1");

                    b.HasIndex("EmployeeId1");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BookingSystem.BuisnessLogic.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookingSystem.BuisnessLogic.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BookingSystem.BuisnessLogic.Entities.Appointment", b =>
                {
                    b.HasOne("BookingSystem.BuisnessLogic.Entities.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerId1");

                    b.HasOne("BookingSystem.BuisnessLogic.Entities.Employee", "Employee")
                        .WithMany("Appointments")
                        .HasForeignKey("EmployeeId1");
                });
#pragma warning restore 612, 618
        }
    }
}
