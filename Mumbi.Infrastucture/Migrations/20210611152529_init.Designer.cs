﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mumbi.Infrastucture.Context;

namespace Mumbi.Infrastucture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210611152529_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mumbi.Domain.Entities.Account", b =>
                {
                    b.Property<string>("AccountId")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Action", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ActionType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Action");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.ActionChild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActionId")
                        .HasColumnType("int");

                    b.Property<string>("ChildId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ActionId");

                    b.HasIndex("ChildId");

                    b.ToTable("ActionChild");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Child", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<double?>("AvgMilk")
                        .HasColumnType("float");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime");

                    b.Property<string>("BloodGroup")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("DadId")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Fingertips")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<double?>("HeadCircumference")
                        .HasColumnType("float");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<double?>("HourSleep")
                        .HasColumnType("float");

                    b.Property<string>("Image")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("MomId")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.Property<string>("RhBloodGroup")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DadId");

                    b.HasIndex("MomId");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Dad", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<string>("BloodGroup")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Phonenumber")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("RhBloodGroup")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Dad");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Diary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChildId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("DiaryContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.ToTable("Diary");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Doctor", b =>
                {
                    b.Property<string>("AccountId")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<string>("FromHospital")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.Property<string>("Image")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("AccountId")
                        .HasName("PK__Doctor__349DA5A69BAFC2B6");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Guidebook", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("EstimateFinishTime")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("GuidebookContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSaved")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Guidebook");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.GuildbookType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("GuildbookType");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.InjectionSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChildrenId")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("InjectionDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsInjection")
                        .HasColumnType("bit");

                    b.Property<string>("MotherId")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("NextInjectionDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("OrderOfInjection")
                        .HasColumnType("int");

                    b.Property<string>("Phonenumber")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("VaccineId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ChildrenId");

                    b.HasIndex("MotherId");

                    b.HasIndex("VaccineId");

                    b.ToTable("InjectionSchedule");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Mom", b =>
                {
                    b.Property<string>("AccountId")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<string>("BloodGroup")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Image")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool?>("IsSingleMom")
                        .HasColumnType("bit");

                    b.Property<string>("Phonenumber")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("RhBloodGroup")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("AccountId")
                        .HasName("PK__Mom__349DA5A68520F284");

                    b.ToTable("Mom");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.News", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("EstimateFinishTime")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Image")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("NewsContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.NewsType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("NewsType");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.PregnancyActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityName")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("ChildId")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("IsDone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("MediaFile")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("TypeId");

                    b.ToTable("PregnancyActivity");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.PregnancyActivityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("SuitableAge")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("PregnancyActivityType");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.PregnancyInformation", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CalculatedBornDate")
                        .HasColumnType("datetime");

                    b.Property<double?>("FemurLength")
                        .HasColumnType("float");

                    b.Property<double?>("FetalHeartRate")
                        .HasColumnType("float");

                    b.Property<double?>("HeadCircumference")
                        .HasColumnType("float");

                    b.Property<int?>("MotherMenstrualCycleTime")
                        .HasColumnType("int");

                    b.Property<double?>("MotherWeight")
                        .HasColumnType("float");

                    b.Property<string>("PregnancyType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PregnancyWeek")
                        .HasColumnType("int");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("PregnancyInformation");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Reminder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Frequency")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<TimeSpan?>("Time")
                        .HasColumnType("time");

                    b.Property<string>("TypeRemind")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Reminder");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Token1")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Token");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Token");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Tooth", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EstimateGrowTime")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("GrowTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsGrown")
                        .HasColumnType("bit");

                    b.Property<string>("ToothName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ToothNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teeth");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Vaccine", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DiseaseName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductionCountry")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("VaccineName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Vaccine");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.staff", b =>
                {
                    b.Property<string>("AccountId")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("AccountId")
                        .HasName("PK__Staff__349DA5A69F3B2D6C");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Account", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_Account_Role")
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.ActionChild", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Action", "Action")
                        .WithMany("ActionChildren")
                        .HasForeignKey("ActionId")
                        .HasConstraintName("FK_ActionChild_Action")
                        .IsRequired();

                    b.HasOne("Mumbi.Domain.Entities.Child", "Child")
                        .WithMany("ActionChildren")
                        .HasForeignKey("ChildId")
                        .HasConstraintName("FK_ActionChild_Child")
                        .IsRequired();

                    b.Navigation("Action");

                    b.Navigation("Child");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Child", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Dad", "Dad")
                        .WithMany("Children")
                        .HasForeignKey("DadId")
                        .HasConstraintName("FK_Children_Dad");

                    b.HasOne("Mumbi.Domain.Entities.Mom", "Mom")
                        .WithMany("Children")
                        .HasForeignKey("MomId")
                        .HasConstraintName("FK_Children_Mom");

                    b.Navigation("Dad");

                    b.Navigation("Mom");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Diary", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Child", "Child")
                        .WithMany("Diaries")
                        .HasForeignKey("ChildId")
                        .HasConstraintName("FK_Diary_Children")
                        .IsRequired();

                    b.Navigation("Child");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Doctor", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Account", "Account")
                        .WithOne("Doctor")
                        .HasForeignKey("Mumbi.Domain.Entities.Doctor", "AccountId")
                        .HasConstraintName("FK_Doctor_Account")
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Guidebook", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.GuildbookType", "Type")
                        .WithMany("Guidebooks")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_Guidebook_GuildbookType");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.InjectionSchedule", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Child", "Children")
                        .WithMany("InjectionSchedules")
                        .HasForeignKey("ChildrenId")
                        .HasConstraintName("FK_InjectionSchedule_Children");

                    b.HasOne("Mumbi.Domain.Entities.Mom", "Mother")
                        .WithMany("InjectionSchedules")
                        .HasForeignKey("MotherId")
                        .HasConstraintName("FK_InjectionSchedule_Mom");

                    b.HasOne("Mumbi.Domain.Entities.Vaccine", "Vaccine")
                        .WithMany("InjectionSchedules")
                        .HasForeignKey("VaccineId")
                        .HasConstraintName("FK_InjectionSchedule_Vaccine")
                        .IsRequired();

                    b.Navigation("Children");

                    b.Navigation("Mother");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Mom", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Account", "Account")
                        .WithOne("Mom")
                        .HasForeignKey("Mumbi.Domain.Entities.Mom", "AccountId")
                        .HasConstraintName("FK_Account_Mom")
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.News", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.NewsType", "Type")
                        .WithMany("News")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_News_NewsType");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.PregnancyActivity", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Child", "Child")
                        .WithMany("PregnancyActivities")
                        .HasForeignKey("ChildId")
                        .HasConstraintName("FK_Activity_Children");

                    b.HasOne("Mumbi.Domain.Entities.PregnancyActivityType", "Type")
                        .WithMany("PregnancyActivities")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_Activity_ActivityType");

                    b.Navigation("Child");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.PregnancyInformation", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Child", "IdNavigation")
                        .WithOne("PregnancyInformation")
                        .HasForeignKey("Mumbi.Domain.Entities.PregnancyInformation", "Id")
                        .HasConstraintName("FK_Children_Pregnancy")
                        .IsRequired();

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Reminder", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Account", "Account")
                        .WithMany("Reminders")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_Reminder_Account")
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Token", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Account", "Account")
                        .WithMany("Tokens")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK_Token_Account")
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Tooth", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Child", "IdNavigation")
                        .WithOne("Tooth")
                        .HasForeignKey("Mumbi.Domain.Entities.Tooth", "Id")
                        .HasConstraintName("FK_Teeth_Child")
                        .IsRequired();

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.staff", b =>
                {
                    b.HasOne("Mumbi.Domain.Entities.Account", "Account")
                        .WithOne("staff")
                        .HasForeignKey("Mumbi.Domain.Entities.staff", "AccountId")
                        .HasConstraintName("FK_Staff_Account")
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Account", b =>
                {
                    b.Navigation("Doctor");

                    b.Navigation("Mom");

                    b.Navigation("Reminders");

                    b.Navigation("staff");

                    b.Navigation("Tokens");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Action", b =>
                {
                    b.Navigation("ActionChildren");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Child", b =>
                {
                    b.Navigation("ActionChildren");

                    b.Navigation("Diaries");

                    b.Navigation("InjectionSchedules");

                    b.Navigation("PregnancyActivities");

                    b.Navigation("PregnancyInformation");

                    b.Navigation("Tooth");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Dad", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.GuildbookType", b =>
                {
                    b.Navigation("Guidebooks");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Mom", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("InjectionSchedules");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.NewsType", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.PregnancyActivityType", b =>
                {
                    b.Navigation("PregnancyActivities");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Mumbi.Domain.Entities.Vaccine", b =>
                {
                    b.Navigation("InjectionSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}