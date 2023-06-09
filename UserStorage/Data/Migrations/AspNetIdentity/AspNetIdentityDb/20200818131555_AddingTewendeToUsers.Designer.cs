﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserStorage.Data;

namespace UserStorage.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20200818131555_AddingTewendeToUsers")]
    partial class AddingTewendeToUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "name",
                            ClaimValue = "Alice Smith",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "given_name",
                            ClaimValue = "Alice",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "family_name",
                            ClaimValue = "Smith",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "email",
                            ClaimValue = "AliceSmith@email.com",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "website",
                            ClaimValue = "http://alice.com",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "name",
                            ClaimValue = "Bob Smith",
                            UserId = "2"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "given_name",
                            ClaimValue = "Bob",
                            UserId = "2"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "family_name",
                            ClaimValue = "Smith",
                            UserId = "2"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "email",
                            ClaimValue = "BobSmith@email.com",
                            UserId = "2"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "website",
                            ClaimValue = "http://bob.com",
                            UserId = "2"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "email_verified",
                            ClaimValue = "True",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "email_verified",
                            ClaimValue = "True",
                            UserId = "2"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "address",
                            ClaimValue = "{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "address",
                            ClaimValue = "{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }",
                            UserId = "2"
                        },
                        new
                        {
                            Id = 15,
                            ClaimType = "location",
                            ClaimValue = "somewhere",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 16,
                            ClaimType = "name",
                            ClaimValue = "Tewende Bagbila",
                            UserId = "3"
                        },
                        new
                        {
                            Id = 17,
                            ClaimType = "given_name",
                            ClaimValue = "Tewende",
                            UserId = "3"
                        },
                        new
                        {
                            Id = 18,
                            ClaimType = "family_name",
                            ClaimValue = "Bagbila",
                            UserId = "3"
                        },
                        new
                        {
                            Id = 19,
                            ClaimType = "email",
                            ClaimValue = "tewende@test.com",
                            UserId = "3"
                        },
                        new
                        {
                            Id = 20,
                            ClaimType = "website",
                            ClaimValue = "http://tewende.com",
                            UserId = "3"
                        },
                        new
                        {
                            Id = 21,
                            ClaimType = "email_verified",
                            ClaimValue = "True",
                            UserId = "3"
                        },
                        new
                        {
                            Id = 22,
                            ClaimType = "address",
                            ClaimValue = "{ 'street_address': 'One Hacker Way', 'locality': 'London', 'postal_code': SW17 9JY, 'country': 'United Kingdom' }",
                            UserId = "3"
                        },
                        new
                        {
                            Id = 23,
                            ClaimType = "location",
                            ClaimValue = "anywhere",
                            UserId = "3"
                        });
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

            modelBuilder.Entity("UserStorage.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "669a46a4-315e-462c-b0ac-4f552292526b",
                            Email = "AliceSmith@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALICESMITH@EMAIL.COM",
                            NormalizedUserName = "ALICE",
                            PasswordHash = "AQAAAAEAACcQAAAAEDz+/g9LITZXileI42bq7+tLHRR9WDc1EU3TqlAps366xwIIqVgkVxE3NSIV0XCOIQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aca391d8-ef0b-4b14-8d42-e92576ad0b13",
                            TwoFactorEnabled = false,
                            UserName = "alice"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "827fe977-005e-4b62-824b-8fd68cdd63d6",
                            Email = "BobSmith@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "BOBSMITH@EMAIL.COM",
                            NormalizedUserName = "BOB",
                            PasswordHash = "AQAAAAEAACcQAAAAEO53gyFhbucyeUB14BURFNcFNm0uS6k1GQ+MSlv1Vj4gzBq2AMBhi+hug9bHQYvkTA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "73a66b0c-0bd9-402d-9d8a-99c96d578b0c",
                            TwoFactorEnabled = false,
                            UserName = "bob"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dafaeb9b-0718-4d4c-a122-162f6bec7139",
                            Email = "tewende@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEWENDE@TEST.COM",
                            NormalizedUserName = "TEWENDE",
                            PasswordHash = "AQAAAAEAACcQAAAAEOC/5wOgBYkBv0LBltYK+TgPs6mPAumn5LNzF+KEBlh+mXQidsSuenCuvrF1O7tGXg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "475e665f-0dcb-4c36-bad9-16aee779d70f",
                            TwoFactorEnabled = false,
                            UserName = "tewende"
                        });
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
                    b.HasOne("UserStorage.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UserStorage.Models.ApplicationUser", null)
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

                    b.HasOne("UserStorage.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UserStorage.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
