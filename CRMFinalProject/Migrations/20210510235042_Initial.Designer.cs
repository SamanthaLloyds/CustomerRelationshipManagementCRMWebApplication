﻿// <auto-generated />
using System;
using CooperativeFuneralFundInc.Models.SupplyRequest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CooperativeFuneralFundInc.Migrations
{
    [DbContext(typeof(CFFDataContext))]
    [Migration("20210510235042_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.DropDownMenu.ClientSupplier", b =>
                {
                    b.Property<int>("ClientSupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientSupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientSupplierID");

                    b.ToTable("ClientSuppliers");

                    b.HasData(
                        new
                        {
                            ClientSupplierID = 1,
                            ClientSupplierName = "Client 1"
                        },
                        new
                        {
                            ClientSupplierID = 2,
                            ClientSupplierName = "Client 2"
                        });
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.DropDownMenu.OrderItems", b =>
                {
                    b.Property<string>("OrderItemsID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderItemsName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderItemsID");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemsID = "Preneed agreement",
                            OrderItemsName = "Preneed agreement"
                        },
                        new
                        {
                            OrderItemsID = "Account update/Claim form",
                            OrderItemsName = "Account update/Claim form"
                        },
                        new
                        {
                            OrderItemsID = "Itemizations form",
                            OrderItemsName = "Itemizations form"
                        },
                        new
                        {
                            OrderItemsID = "Return envelopes.",
                            OrderItemsName = "Return envelopes."
                        },
                        new
                        {
                            OrderItemsID = "Postage paid envelopes.",
                            OrderItemsName = "Postage paid envelopes."
                        },
                        new
                        {
                            OrderItemsID = "Deposit tickets",
                            OrderItemsName = "Deposit tickets"
                        },
                        new
                        {
                            OrderItemsID = "Planning guides",
                            OrderItemsName = "Planning guides"
                        },
                        new
                        {
                            OrderItemsID = "Funding your funeral in advance brochure",
                            OrderItemsName = "Funding your funeral in advance brochure"
                        },
                        new
                        {
                            OrderItemsID = "Monthly monitors",
                            OrderItemsName = "Monthly monitors"
                        },
                        new
                        {
                            OrderItemsID = "Service and merchandise forms",
                            OrderItemsName = "Service and merchandise forms"
                        },
                        new
                        {
                            OrderItemsID = "Investment election form",
                            OrderItemsName = "Investment election form"
                        },
                        new
                        {
                            OrderItemsID = "Other",
                            OrderItemsName = "Other"
                        });
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.DropDownMenu.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerId");

                    b.ToTable("OwnerNames");
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.DropDownMenu.Priority", b =>
                {
                    b.Property<string>("PriorityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PriorityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PriorityId");

                    b.ToTable("Priorities");

                    b.HasData(
                        new
                        {
                            PriorityId = "High",
                            PriorityName = "High"
                        },
                        new
                        {
                            PriorityId = "Medium",
                            PriorityName = "Medium"
                        },
                        new
                        {
                            PriorityId = "Low",
                            PriorityName = "Low"
                        });
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.DropDownMenu.RelatedTo", b =>
                {
                    b.Property<string>("RelatedToId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RelatedToName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RelatedToId");

                    b.ToTable("RelatedTos");

                    b.HasData(
                        new
                        {
                            RelatedToId = "Customer",
                            RelatedToName = "Customer"
                        },
                        new
                        {
                            RelatedToId = "Potential customer",
                            RelatedToName = "Potential customer"
                        },
                        new
                        {
                            RelatedToId = "Lead",
                            RelatedToName = "Lead"
                        },
                        new
                        {
                            RelatedToId = "In-house",
                            RelatedToName = "In-house"
                        },
                        new
                        {
                            RelatedToId = "Other",
                            RelatedToName = "Other"
                        });
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.DropDownMenu.RequestOrigin", b =>
                {
                    b.Property<string>("RequestOriginId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RequestOriginDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestOriginId");

                    b.ToTable("RequestOrigins");

                    b.HasData(
                        new
                        {
                            RequestOriginId = "Phone",
                            RequestOriginDescription = "Phone"
                        },
                        new
                        {
                            RequestOriginId = "Fax",
                            RequestOriginDescription = "Fax"
                        },
                        new
                        {
                            RequestOriginId = "Email",
                            RequestOriginDescription = "Email"
                        },
                        new
                        {
                            RequestOriginId = "Mail",
                            RequestOriginDescription = "Mail"
                        },
                        new
                        {
                            RequestOriginId = "Regional Manager",
                            RequestOriginDescription = "Regional manager"
                        },
                        new
                        {
                            RequestOriginId = "Other",
                            RequestOriginDescription = "Other"
                        });
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.DropDownMenu.RequestType", b =>
                {
                    b.Property<string>("RequestTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RequestTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestTypeId");

                    b.ToTable("RequestTypes");

                    b.HasData(
                        new
                        {
                            RequestTypeId = "Vendor",
                            RequestTypeDescription = "Vendor"
                        },
                        new
                        {
                            RequestTypeId = "Client",
                            RequestTypeDescription = "Client"
                        });
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.DropDownMenu.Status", b =>
                {
                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StatusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = "New",
                            StatusDescription = "New"
                        },
                        new
                        {
                            StatusId = "In-Process",
                            StatusDescription = "In-Process"
                        },
                        new
                        {
                            StatusId = "Completed",
                            StatusDescription = "Completed"
                        },
                        new
                        {
                            StatusId = "On hold",
                            StatusDescription = "On hold"
                        },
                        new
                        {
                            StatusId = "Cancelled",
                            StatusDescription = "Cancelled"
                        });
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.SupplyRequest.SupplyRequest", b =>
                {
                    b.Property<int>("SupplyRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderItems")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplyRequestOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("SupplyRequestId");

                    b.ToTable("SupplyRequests");
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.TasksManagement.TaskManagement", b =>
                {
                    b.Property<int>("TaskManagementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelatedTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelatedToName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("TaskManagementId");

                    b.ToTable("TaskManagements");
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.UserManagement.PhoneNumberType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NumberTypes");

                    b.HasData(
                        new
                        {
                            Id = "Home",
                            Name = "Home"
                        },
                        new
                        {
                            Id = "Mobile",
                            Name = "Mobile"
                        },
                        new
                        {
                            Id = "Work",
                            Name = "work"
                        },
                        new
                        {
                            Id = "Other",
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("CooperativeFuneralFundInc.Models.UserManagement.User", b =>
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

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numberType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

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
                    b.HasOne("CooperativeFuneralFundInc.Models.UserManagement.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CooperativeFuneralFundInc.Models.UserManagement.User", null)
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

                    b.HasOne("CooperativeFuneralFundInc.Models.UserManagement.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CooperativeFuneralFundInc.Models.UserManagement.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
