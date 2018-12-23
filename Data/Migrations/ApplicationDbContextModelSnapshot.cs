﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NET.Core.V2_2.Data;

namespace NET.Core.V2_2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NET.Core.V2_2.Models.FTP_FileGroup", b =>
                {
                    b.Property<int>("FGId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PId");

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasDefaultValue(0);

                    b.HasKey("FGId");

                    b.HasIndex("PId");

                    b.ToTable("FTP_FileGroup");
                });

            modelBuilder.Entity("NET.Core.V2_2.Models.FTP_FileUrl", b =>
                {
                    b.Property<int>("FUId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FGId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasDefaultValue(0);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("FUId");

                    b.HasIndex("FGId");

                    b.ToTable("FTP_FileUrl");
                });

            modelBuilder.Entity("NET.Core.V2_2.Models.FTP_Page", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Explain")
                        .HasMaxLength(50);

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasDefaultValue(0);

                    b.HasKey("PId");

                    b.ToTable("FTP_Page");
                });

            modelBuilder.Entity("NET.Core.V2_2.Models.Test1", b =>
                {
                    b.Property<Guid>("Tid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Explain")
                        .HasMaxLength(50);

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasDefaultValue(0);

                    b.HasKey("Tid");

                    b.ToTable("Test1s");

                    b.HasData(
                        new
                        {
                            Tid = new Guid("a1952052-7fdc-411d-86e3-dade962fb790"),
                            Address = "http://sample.com",
                            Explain = "fds",
                            Sort = 0
                        });
                });

            modelBuilder.Entity("NET.Core.V2_2.Models.Test2", b =>
                {
                    b.Property<Guid>("Tid")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Address");

                    b.Property<string>("Explain");

                    b.Property<int>("Sort")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasDefaultValue(0);

                    b.HasKey("Tid");

                    b.ToTable("Test2s");

                    b.HasData(
                        new
                        {
                            Tid = new Guid("61d8230f-7b89-4f15-8e79-ae65966a929e"),
                            Address = "1",
                            Explain = "1",
                            Sort = 0
                        },
                        new
                        {
                            Tid = new Guid("31975595-26e5-47c1-bb8c-21b579a11b6b"),
                            Address = "2",
                            Explain = "1",
                            Sort = 0
                        },
                        new
                        {
                            Tid = new Guid("17ba4f00-ed3a-4a2f-9a2f-26bdb9f11420"),
                            Address = "3",
                            Explain = "4",
                            Sort = 0
                        },
                        new
                        {
                            Tid = new Guid("c4fb37e8-9f4d-40a8-b469-06b026e682a4"),
                            Address = "5",
                            Explain = "5",
                            Sort = 0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NET.Core.V2_2.Models.FTP_FileGroup", b =>
                {
                    b.HasOne("NET.Core.V2_2.Models.FTP_Page", "FTP_Page")
                        .WithMany("FTP_FileGroups")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NET.Core.V2_2.Models.FTP_FileUrl", b =>
                {
                    b.HasOne("NET.Core.V2_2.Models.FTP_FileGroup", "FTP_FileGroup")
                        .WithMany("FTP_FileUrls")
                        .HasForeignKey("FGId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
