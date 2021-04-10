﻿// <auto-generated />
using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Attendence_GP.Migrations
{
    [DbContext(typeof(ITIAttendanceContext))]
    partial class ITIAttendanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Attendance", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("Student_ID");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("AttendAt")
                        .HasColumnType("time");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created_By");

                    b.Property<TimeSpan?>("LeaveAt")
                        .HasColumnType("time");

                    b.HasKey("StudentId", "Date")
                        .HasName("PK_Attendees_1");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("Domain.Models.Emplyee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date")
                        .HasColumnName("Created_Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("Role_id");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("RoleId");

                    b.ToTable("Emplyee");
                });

            modelBuilder.Entity("Domain.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("date")
                        .HasColumnName("Create_Date");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Noe")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("ResponseBy")
                        .HasColumnType("int")
                        .HasColumnName("Response_by");

                    b.Property<DateTime?>("ResponseDate")
                        .HasColumnType("date")
                        .HasColumnName("Response_Date");

                    b.Property<bool?>("ResponseType")
                        .HasColumnType("bit")
                        .HasColumnName("Response_type");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("Student_ID");

                    b.Property<bool>("Type")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ResponseBy");

                    b.HasIndex("StudentId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("Domain.Models.Program", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Program");
                });

            modelBuilder.Entity("Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Role");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Domain.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Created_By");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("date")
                        .HasColumnName("Created_Date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ssn")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SSN");

                    b.Property<string>("Telephone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrackActionId")
                        .HasColumnType("int")
                        .HasColumnName("Ttack_Action_ID");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("TrackActionId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Domain.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int")
                        .HasColumnName("Program_id");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("Domain.Models.TrackAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("End")
                        .HasColumnType("date")
                        .HasColumnName("end");

                    b.Property<DateTime>("Start")
                        .HasColumnType("date");

                    b.Property<int>("TrackId")
                        .HasColumnType("int")
                        .HasColumnName("Track_Id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.ToTable("Track_Action");
                });

            modelBuilder.Entity("Domain.Models.Attendance", b =>
                {
                    b.HasOne("Domain.Models.Emplyee", "CreatedByNavigation")
                        .WithMany("Attendances")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK_Attendees_Emplyee")
                        .IsRequired();

                    b.HasOne("Domain.Models.Student", "Student")
                        .WithMany("Attendees")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK_Attendees_Student")
                        .IsRequired();

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.Models.Emplyee", b =>
                {
                    b.HasOne("Domain.Models.Emplyee", "CreatedByNavigation")
                        .WithMany("InverseCreatedByNavigation")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK_Emplyee_Emplyee")
                        .IsRequired();

                    b.HasOne("Domain.Models.Role", "Role")
                        .WithMany("Emplyees")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_Emplyee_Role")
                        .IsRequired();

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Models.Permission", b =>
                {
                    b.HasOne("Domain.Models.Emplyee", "ResponseByNavigation")
                        .WithMany("Permissions")
                        .HasForeignKey("ResponseBy")
                        .HasConstraintName("FK_Permission_Emplyee");

                    b.HasOne("Domain.Models.Student", "Student")
                        .WithMany("Permissions")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK_Permission_Student")
                        .IsRequired();

                    b.Navigation("ResponseByNavigation");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.Models.Student", b =>
                {
                    b.HasOne("Domain.Models.Emplyee", "CreatedByNavigation")
                        .WithMany("Students")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("FK_Student_Emplyee");

                    b.HasOne("Domain.Models.TrackAction", "TtackAction")
                        .WithMany("Students")
                        .HasForeignKey("TrackActionId")
                        .HasConstraintName("FK_Student_Track_Action");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("TtackAction");
                });

            modelBuilder.Entity("Domain.Models.Track", b =>
                {
                    b.HasOne("Domain.Models.Program", "Program")
                        .WithMany("Tracks")
                        .HasForeignKey("ProgramId")
                        .HasConstraintName("FK_Track_Program")
                        .IsRequired();

                    b.Navigation("Program");
                });

            modelBuilder.Entity("Domain.Models.TrackAction", b =>
                {
                    b.HasOne("Domain.Models.Track", "Track")
                        .WithMany("TrackActions")
                        .HasForeignKey("TrackId")
                        .HasConstraintName("FK_Track_Action_Track")
                        .IsRequired();

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Domain.Models.Emplyee", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("InverseCreatedByNavigation");

                    b.Navigation("Permissions");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Domain.Models.Program", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Domain.Models.Role", b =>
                {
                    b.Navigation("Emplyees");
                });

            modelBuilder.Entity("Domain.Models.Student", b =>
                {
                    b.Navigation("Attendees");

                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("Domain.Models.Track", b =>
                {
                    b.Navigation("TrackActions");
                });

            modelBuilder.Entity("Domain.Models.TrackAction", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
