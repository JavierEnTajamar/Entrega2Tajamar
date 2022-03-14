﻿// <auto-generated />
using System;
using LightHouseV1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LightHouseV1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220211184526_M9")]
    partial class M9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LightHouseV1.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("LightHouseV1.Models.Castaway", b =>
                {
                    b.Property<int>("CastawayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CastawayHomeDoor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CastawayHomeFloor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CastawayHomeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CastawayHomePortal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CastawayLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CastawayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CastawayPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CastawayRoadName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CastawayRoadType")
                        .HasColumnType("int");

                    b.Property<string>("CastawaySecondLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CastawayTelephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CastawayTwitchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CastawayId");

                    b.HasIndex("UserId");

                    b.ToTable("Castaways");
                });

            modelBuilder.Entity("LightHouseV1.Models.ClaimedBy", b =>
                {
                    b.Property<int>("ClaimedById")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimedByType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClaimedById");

                    b.ToTable("ClaimedBys");
                });

            modelBuilder.Entity("LightHouseV1.Models.Reward", b =>
                {
                    b.Property<int>("RewardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BuyPrice")
                        .HasColumnType("float");

                    b.Property<int?>("CastawayId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ClaimDay")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ClaimedById")
                        .HasColumnType("int");

                    b.Property<string>("RewardColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RewardCompositionId")
                        .HasColumnType("int");

                    b.Property<string>("RewardSprayColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RewardStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("RewardTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TemplateId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("RewardId");

                    b.HasIndex("CastawayId");

                    b.HasIndex("ClaimedById");

                    b.HasIndex("RewardCompositionId");

                    b.HasIndex("RewardStatusId");

                    b.HasIndex("RewardTypeId");

                    b.HasIndex("TemplateId");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("LightHouseV1.Models.RewardComposition", b =>
                {
                    b.Property<int>("RewardCompositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RewardComponents")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RewardCompositionId");

                    b.ToTable("RewardCompositions");
                });

            modelBuilder.Entity("LightHouseV1.Models.RewardStatus", b =>
                {
                    b.Property<int>("RewardStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RewardStatusType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RewardStatusId");

                    b.ToTable("RewardStatuses");
                });

            modelBuilder.Entity("LightHouseV1.Models.RewardType", b =>
                {
                    b.Property<int>("RewardTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RewardTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RewardTypeId");

                    b.ToTable("RewardTypes");
                });

            modelBuilder.Entity("LightHouseV1.Models.Send", b =>
                {
                    b.Property<int>("SendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ReceptionDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SendDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("SendName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SendPrice")
                        .HasColumnType("float");

                    b.Property<int>("SendType")
                        .HasColumnType("int");

                    b.HasKey("SendId");

                    b.ToTable("Sends");
                });

            modelBuilder.Entity("LightHouseV1.Models.SendContent", b =>
                {
                    b.Property<int>("SendTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RewardId")
                        .HasColumnType("int");

                    b.Property<int?>("SendId")
                        .HasColumnType("int");

                    b.HasKey("SendTypeId");

                    b.HasIndex("RewardId");

                    b.HasIndex("SendId");

                    b.ToTable("SendContents");
                });

            modelBuilder.Entity("LightHouseV1.Models.Template", b =>
                {
                    b.Property<int>("TemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TemplateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TemplateId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LightHouseV1.Models.Castaway", b =>
                {
                    b.HasOne("LightHouseV1.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LightHouseV1.Models.Reward", b =>
                {
                    b.HasOne("LightHouseV1.Models.Castaway", "Castaway")
                        .WithMany()
                        .HasForeignKey("CastawayId");

                    b.HasOne("LightHouseV1.Models.ClaimedBy", "ClaimedBy")
                        .WithMany()
                        .HasForeignKey("ClaimedById");

                    b.HasOne("LightHouseV1.Models.RewardComposition", "RewardComposition")
                        .WithMany()
                        .HasForeignKey("RewardCompositionId");

                    b.HasOne("LightHouseV1.Models.RewardStatus", "RewardStatus")
                        .WithMany()
                        .HasForeignKey("RewardStatusId");

                    b.HasOne("LightHouseV1.Models.RewardType", "RewardType")
                        .WithMany()
                        .HasForeignKey("RewardTypeId");

                    b.HasOne("LightHouseV1.Models.Template", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId");

                    b.Navigation("Castaway");

                    b.Navigation("ClaimedBy");

                    b.Navigation("RewardComposition");

                    b.Navigation("RewardStatus");

                    b.Navigation("RewardType");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("LightHouseV1.Models.SendContent", b =>
                {
                    b.HasOne("LightHouseV1.Models.Reward", "Reward")
                        .WithMany()
                        .HasForeignKey("RewardId");

                    b.HasOne("LightHouseV1.Models.Send", "Send")
                        .WithMany()
                        .HasForeignKey("SendId");

                    b.Navigation("Reward");

                    b.Navigation("Send");
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
                    b.HasOne("LightHouseV1.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LightHouseV1.Models.ApplicationUser", null)
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

                    b.HasOne("LightHouseV1.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LightHouseV1.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
