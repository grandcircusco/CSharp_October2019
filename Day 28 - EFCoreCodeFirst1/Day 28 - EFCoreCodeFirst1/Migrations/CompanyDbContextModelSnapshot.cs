﻿// <auto-generated />
using Day_28___EFCoreCodeFirst1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Day_28___EFCoreCodeFirst1.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    partial class CompanyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Day_28___EFCoreCodeFirst1.Context.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Budget")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Budget = 0.0,
                            Location = "Not found",
                            Name = "Orphan Employees",
                            Type = "Lost"
                        },
                        new
                        {
                            DepartmentId = 2,
                            Budget = 0.29999999999999999,
                            Location = "East Wing",
                            Name = "Accounting",
                            Type = "Finance"
                        },
                        new
                        {
                            DepartmentId = 3,
                            Budget = 5000000.0,
                            Location = "West Wing",
                            Name = "Marketing",
                            Type = "Advertising"
                        },
                        new
                        {
                            DepartmentId = 4,
                            Budget = 16.0,
                            Location = "Sales Floor",
                            Name = "Sales",
                            Type = "Peons"
                        });
                });

            modelBuilder.Entity("Day_28___EFCoreCodeFirst1.Context.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DepartmentId = 3,
                            Email = "Marty@McFly.co",
                            FirstName = "Marty",
                            LastName = "McFly"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DepartmentId = 1,
                            Email = "Tannen@McFly.co",
                            FirstName = "Biff",
                            LastName = "Tannen"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DepartmentId = 3,
                            Email = "George@McFly.co",
                            FirstName = "George",
                            LastName = "McFly"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DepartmentId = 2,
                            Email = "Jennifer@McFly.co",
                            FirstName = "Jennifer",
                            LastName = "Parker"
                        },
                        new
                        {
                            EmployeeId = 5,
                            DepartmentId = 1,
                            Email = "Emmett@Brown.co",
                            FirstName = "Emmett",
                            LastName = "Brown"
                        },
                        new
                        {
                            EmployeeId = 6,
                            DepartmentId = 2,
                            Email = "Clara@Brown.co",
                            FirstName = "Clara",
                            LastName = "Clayton"
                        });
                });

            modelBuilder.Entity("Day_28___EFCoreCodeFirst1.Context.Employee", b =>
                {
                    b.HasOne("Day_28___EFCoreCodeFirst1.Context.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
