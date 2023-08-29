﻿// <auto-generated />
using System;
using ElkoodTaskCA.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ElkoodTaskCA.Persistence.Migrations
{
    [DbContext(typeof(ElkoodTaskCADbContext))]
    partial class ElkoodTaskCADbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.BranchInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("CompanyInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("BranchTypeId");

                    b.HasIndex("CompanyInfoId");

                    b.ToTable("BranchInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchTypeId = 1,
                            CompanyInfoId = 1,
                            Location = "Nevada State",
                            Name = "Gigafactory Nevada"
                        },
                        new
                        {
                            Id = 2,
                            BranchTypeId = 2,
                            CompanyInfoId = 1,
                            Location = "Texas, California",
                            Name = "Texas Store"
                        },
                        new
                        {
                            Id = 3,
                            BranchTypeId = 1,
                            CompanyInfoId = 2,
                            Location = "California State",
                            Name = "Hawthorne Headquarters"
                        },
                        new
                        {
                            Id = 4,
                            BranchTypeId = 2,
                            CompanyInfoId = 2,
                            Location = "USA",
                            Name = "NASA Store"
                        },
                        new
                        {
                            Id = 5,
                            BranchTypeId = 1,
                            CompanyInfoId = 3,
                            Location = "Washington State",
                            Name = "Washington"
                        },
                        new
                        {
                            Id = 6,
                            BranchTypeId = 1,
                            CompanyInfoId = 3,
                            Location = "New York State",
                            Name = "New York"
                        },
                        new
                        {
                            Id = 7,
                            BranchTypeId = 2,
                            CompanyInfoId = 3,
                            Location = "Shanghai, China",
                            Name = "Nanjing East store"
                        });
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.BranchType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("BranchTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Primary"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Secondary"
                        });
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.CompanyInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("EstablishmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("CompanyInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activity = "Electric Vehicles",
                            EstablishmentDate = new DateTime(2003, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Austin, Texas, USA",
                            Name = "Tesla"
                        },
                        new
                        {
                            Id = 2,
                            Activity = "Spacecraft Technology",
                            EstablishmentDate = new DateTime(2002, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Hawthorne, California, USA",
                            Name = "SpaceX"
                        },
                        new
                        {
                            Id = 3,
                            Activity = "Technology Company",
                            EstablishmentDate = new DateTime(1976, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Cupertino, California, USA",
                            Name = "Apple"
                        });
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.DistributionOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BranchInfoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PrimaryBranchInfoId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductInfoId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("SecondaryBranchInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BranchInfoId");

                    b.HasIndex("PrimaryBranchInfoId");

                    b.HasIndex("ProductInfoId");

                    b.HasIndex("SecondaryBranchInfoId");

                    b.ToTable("DistributionOperations");
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.ProductInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "iphone 15",
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Macbook Air",
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Falcon 9",
                            ProductTypeId = 4
                        },
                        new
                        {
                            Id = 4,
                            Name = "Model S",
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "iphone 16",
                            ProductTypeId = 1
                        });
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mobil"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Car"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Rocket"
                        });
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.ProductionOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchInfoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ProductInfoId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("RemainingQuantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BranchInfoId");

                    b.HasIndex("ProductInfoId");

                    b.ToTable("ProductionOperations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchInfoId = 1,
                            Date = new DateTime(2012, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductInfoId = 4,
                            Quantity = 1000,
                            RemainingQuantity = 1000
                        },
                        new
                        {
                            Id = 2,
                            BranchInfoId = 3,
                            Date = new DateTime(2010, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductInfoId = 3,
                            Quantity = 40,
                            RemainingQuantity = 40
                        },
                        new
                        {
                            Id = 3,
                            BranchInfoId = 5,
                            Date = new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductInfoId = 1,
                            Quantity = 50000,
                            RemainingQuantity = 50000
                        },
                        new
                        {
                            Id = 4,
                            BranchInfoId = 6,
                            Date = new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductInfoId = 1,
                            Quantity = 15000,
                            RemainingQuantity = 15000
                        },
                        new
                        {
                            Id = 5,
                            BranchInfoId = 6,
                            Date = new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductInfoId = 5,
                            Quantity = 25000,
                            RemainingQuantity = 25000
                        },
                        new
                        {
                            Id = 6,
                            BranchInfoId = 5,
                            Date = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductInfoId = 2,
                            Quantity = 10000,
                            RemainingQuantity = 10000
                        },
                        new
                        {
                            Id = 7,
                            BranchInfoId = 5,
                            Date = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductInfoId = 1,
                            Quantity = 15000,
                            RemainingQuantity = 15000
                        });
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.UserEntities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.BranchInfo", b =>
                {
                    b.HasOne("ElkoodTaskCA.Domain.Models.MainEntities.BranchType", "BranchType")
                        .WithMany()
                        .HasForeignKey("BranchTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElkoodTaskCA.Domain.Models.MainEntities.CompanyInfo", "CompanyInfo")
                        .WithMany()
                        .HasForeignKey("CompanyInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BranchType");

                    b.Navigation("CompanyInfo");
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.DistributionOperation", b =>
                {
                    b.HasOne("ElkoodTaskCA.Domain.Models.MainEntities.BranchInfo", null)
                        .WithMany("DistributionOperations")
                        .HasForeignKey("BranchInfoId");

                    b.HasOne("ElkoodTaskCA.Domain.Models.MainEntities.BranchInfo", "PrimaryBranchInfo")
                        .WithMany()
                        .HasForeignKey("PrimaryBranchInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ElkoodTaskCA.Domain.Models.MainEntities.ProductInfo", "ProductInfo")
                        .WithMany("DistributionOperations")
                        .HasForeignKey("ProductInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ElkoodTaskCA.Domain.Models.MainEntities.BranchInfo", "SecondaryBranchInfo")
                        .WithMany()
                        .HasForeignKey("SecondaryBranchInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PrimaryBranchInfo");

                    b.Navigation("ProductInfo");

                    b.Navigation("SecondaryBranchInfo");
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.ProductInfo", b =>
                {
                    b.HasOne("ElkoodTaskCA.Domain.Models.MainEntities.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.ProductionOperation", b =>
                {
                    b.HasOne("ElkoodTaskCA.Domain.Models.MainEntities.BranchInfo", "BranchInfo")
                        .WithMany("ProductionOperations")
                        .HasForeignKey("BranchInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ElkoodTaskCA.Domain.Models.MainEntities.ProductInfo", "ProductInfo")
                        .WithMany("ProductionOperations")
                        .HasForeignKey("ProductInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BranchInfo");

                    b.Navigation("ProductInfo");
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
                    b.HasOne("ElkoodTaskCA.Domain.Models.UserEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ElkoodTaskCA.Domain.Models.UserEntities.ApplicationUser", null)
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

                    b.HasOne("ElkoodTaskCA.Domain.Models.UserEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ElkoodTaskCA.Domain.Models.UserEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.BranchInfo", b =>
                {
                    b.Navigation("DistributionOperations");

                    b.Navigation("ProductionOperations");
                });

            modelBuilder.Entity("ElkoodTaskCA.Domain.Models.MainEntities.ProductInfo", b =>
                {
                    b.Navigation("DistributionOperations");

                    b.Navigation("ProductionOperations");
                });
#pragma warning restore 612, 618
        }
    }
}
