﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Weaver.Data;

namespace Weaver.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Weaver.Data.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Weaver.Data.Models.JournalComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Col")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("JournalComponents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("JournalComponent");
                });

            modelBuilder.Entity("Weaver.Data.Models.JournalTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("JournalTemplateId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("OwnerId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int?>("RootComponentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JournalTemplateId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("RootComponentId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("Weaver.Data.Models.JournalGrid", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.JournalComponent");

                    b.HasDiscriminator().HasValue("JournalGrid");
                });

            modelBuilder.Entity("Weaver.Data.Models.RadioList", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.JournalComponent");

                    b.HasDiscriminator().HasValue("RadioList");
                });

            modelBuilder.Entity("Weaver.Data.Models.ValueComponent<System.DateTime>", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.JournalComponent");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasDiscriminator().HasValue("ValueComponent<DateTime>");
                });

            modelBuilder.Entity("Weaver.Data.Models.ValueComponent<bool>", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.JournalComponent");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("ValueComponent<bool>_Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasDiscriminator().HasValue("ValueComponent<bool>");
                });

            modelBuilder.Entity("Weaver.Data.Models.ValueComponent<double>", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.JournalComponent");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("ValueComponent<double>_Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasDiscriminator().HasValue("ValueComponent<double>");
                });

            modelBuilder.Entity("Weaver.Data.Models.ValueComponent<string>", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.JournalComponent");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("ValueComponent<string>_Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasDiscriminator().HasValue("ValueComponent<string>");
                });

            modelBuilder.Entity("Weaver.Data.Models.DatePicker", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<System.DateTime>");

                    b.Property<bool>("EnableTime")
                        .HasColumnType("tinyint(1)");

                    b.HasDiscriminator().HasValue("DatePicker");
                });

            modelBuilder.Entity("Weaver.Data.Models.CheckBox", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<bool>");

                    b.HasDiscriminator().HasValue("CheckBox");
                });

            modelBuilder.Entity("Weaver.Data.Models.RadioButton", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<bool>");

                    b.Property<int>("ParentListId")
                        .HasColumnType("int");

                    b.HasIndex("ParentListId");

                    b.HasDiscriminator().HasValue("RadioButton");
                });

            modelBuilder.Entity("Weaver.Data.Models.Toggle", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<bool>");

                    b.HasDiscriminator().HasValue("Toggle");
                });

            modelBuilder.Entity("Weaver.Data.Models.NumericField", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<double>");

                    b.Property<short>("DecimalPlaces")
                        .HasColumnType("smallint");

                    b.Property<int>("FieldType")
                        .HasColumnType("int");

                    b.Property<double>("Step")
                        .HasColumnType("double");

                    b.HasDiscriminator().HasValue("NumericField");
                });

            modelBuilder.Entity("Weaver.Data.Models.ResizeableComponent<double>", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<double>");

                    b.Property<bool>("FullHeight")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FullWidth")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("Height")
                        .HasColumnType("float");

                    b.Property<float>("Width")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("ResizeableComponent<double>");
                });

            modelBuilder.Entity("Weaver.Data.Models.FileUploadView", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<string>");

                    b.Property<bool>("IsImageViewer")
                        .HasColumnType("tinyint(1)");

                    b.HasDiscriminator().HasValue("FileUploadView");
                });

            modelBuilder.Entity("Weaver.Data.Models.ResizeableComponent<string>", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<string>");

                    b.Property<bool>("FullHeight")
                        .HasColumnName("ResizeableComponent<string>_FullHeight")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FullWidth")
                        .HasColumnName("ResizeableComponent<string>_FullWidth")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("Height")
                        .HasColumnName("ResizeableComponent<string>_Height")
                        .HasColumnType("float");

                    b.Property<float>("Width")
                        .HasColumnName("ResizeableComponent<string>_Width")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("ResizeableComponent<string>");
                });

            modelBuilder.Entity("Weaver.Data.Models.SelectField", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<string>");

                    b.Property<bool>("Multi")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Options")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasDiscriminator().HasValue("SelectField");
                });

            modelBuilder.Entity("Weaver.Data.Models.TextField", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ValueComponent<string>");

                    b.HasDiscriminator().HasValue("TextField");
                });

            modelBuilder.Entity("Weaver.Data.Models.Slider", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ResizeableComponent<double>");

                    b.Property<double>("Max")
                        .HasColumnType("double");

                    b.Property<double>("Min")
                        .HasColumnType("double");

                    b.Property<double>("Step")
                        .HasColumnName("Slider_Step")
                        .HasColumnType("double");

                    b.HasDiscriminator().HasValue("Slider");
                });

            modelBuilder.Entity("Weaver.Data.Models.TextArea", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.ResizeableComponent<string>");

                    b.HasDiscriminator().HasValue("TextArea");
                });

            modelBuilder.Entity("Weaver.Data.Models.TextEditor", b =>
                {
                    b.HasBaseType("Weaver.Data.Models.TextArea");

                    b.HasDiscriminator().HasValue("TextEditor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Weaver.Data.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Weaver.Data.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weaver.Data.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Weaver.Data.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Weaver.Data.Models.JournalComponent", b =>
                {
                    b.HasOne("Weaver.Data.Models.JournalGrid", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Weaver.Data.Models.JournalTemplate", b =>
                {
                    b.HasOne("Weaver.Data.Models.JournalTemplate", null)
                        .WithMany("Journals")
                        .HasForeignKey("JournalTemplateId");

                    b.HasOne("Weaver.Data.Models.AppUser", "Owner")
                        .WithMany("JournalTemplates")
                        .HasForeignKey("OwnerId");

                    b.HasOne("Weaver.Data.Models.JournalGrid", "RootComponent")
                        .WithMany()
                        .HasForeignKey("RootComponentId");
                });

            modelBuilder.Entity("Weaver.Data.Models.RadioButton", b =>
                {
                    b.HasOne("Weaver.Data.Models.RadioList", "ParentList")
                        .WithMany("Buttons")
                        .HasForeignKey("ParentListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
