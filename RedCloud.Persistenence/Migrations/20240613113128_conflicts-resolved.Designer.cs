﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedCloud.Persistenence;

#nullable disable

namespace RedCloud.Persistenence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
<<<<<<<< HEAD:RedCloud.Persistenence/Migrations/20240613113128_conflicts-resolved.Designer.cs
    [Migration("20240613113128_conflicts-resolved")]
    partial class conflictsresolved
========
    [Migration("20240611110033_ResellerUser12")]
    partial class ResellerUser12
>>>>>>>> ResellerUser:RedCloud.Persistenence/Migrations/20240611110033_ResellerUser12.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

<<<<<<<< HEAD:RedCloud.Persistenence/Migrations/20240613113128_conflicts-resolved.Designer.cs
========
            modelBuilder.Entity("OrganizationAdminResellerAdminUser", b =>
                {
                    b.Property<int>("OrganizationAdminsOrgID")
                        .HasColumnType("int");

                    b.Property<int>("ResellerAdminUsersResellerAdminUserId")
                        .HasColumnType("int");

                    b.HasKey("OrganizationAdminsOrgID", "ResellerAdminUsersResellerAdminUserId");

                    b.HasIndex("ResellerAdminUsersResellerAdminUserId");

                    b.ToTable("OrganizationAdminResellerAdminUser");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.Campaign", b =>
                {
                    b.Property<int>("CampaignId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampaignId"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("BrandRegistrationDate")
                        .HasColumnType("date");

                    b.Property<string>("BrandRelationship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampaignDescriptionOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampaignDescriptionTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampaignIdOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CampaignIdTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdentityStatus")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrgID")
                        .HasColumnType("int");

                    b.Property<int>("OrganizationAdminOrgID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("RegistrationDateOne")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("RegistrationDateTwo")
                        .HasColumnType("date");

                    b.Property<DateOnly>("RenewalDateOne")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("RenewalDateTwo")
                        .HasColumnType("date");

                    b.Property<int>("ResellerAdminUserId")
                        .HasColumnType("int");

                    b.Property<string>("UniversalEIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UseCaseOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UseCaseTwo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CampaignId");

                    b.HasIndex("OrganizationAdminOrgID");

                    b.HasIndex("ResellerAdminUserId");

                    b.ToTable("Campaign");
                });

>>>>>>>> ResellerUser:RedCloud.Persistenence/Migrations/20240611110033_ResellerUser12.Designer.cs
            modelBuilder.Entity("RedCloud.Domain.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.OrganizationAdmin", b =>
                {
                    b.Property<int>("OrgID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrgID"));

                    b.Property<string>("AddressLineOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLineTwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrgAdminEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgAdminMobNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgAdminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgAdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrgID");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.ToTable("OrganizationAdmins");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.OrganizationResellerMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrganizationAdminId")
                        .HasColumnType("int");

                    b.Property<int>("ResellerAdminUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationAdminId");

                    b.HasIndex("ResellerAdminUserId");

                    b.ToTable("OrganizationResellerMapping");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.OrganizationUser", b =>
                {
                    b.Property<int>("OrganizationUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizationUserId"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrganizationAdminId")
                        .HasColumnType("int");

                    b.Property<string>("OrganizationUserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationUserFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationUserLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationUserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizationUserId");

                    b.HasIndex("OrganizationAdminId");

                    b.ToTable("OrganizationUsers");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.RedCloudAdmin", b =>
                {
                    b.Property<int>("RedCloudAdminUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RedCloudAdminUserId"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResellerAdminUserId")
                        .HasColumnType("int");

                    b.HasKey("RedCloudAdminUserId");

                    b.HasIndex("ResellerAdminUserId");

                    b.ToTable("RedCloudAdmins");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.ResellerAdminUser", b =>
                {
                    b.Property<int>("ResellerAdminUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResellerAdminUserId"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CompanySupportEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RedCloudAdmin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResellerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResellerAdminUserId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.ToTable("ResellerAdminUsers");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.ResellerUser", b =>
                {
                    b.Property<int>("ResellerUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResellerUserId"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResellerAdminUserId")
                        .HasColumnType("int");

                    b.HasKey("ResellerUserId");

                    b.HasIndex("ResellerAdminUserId");

                    b.ToTable("ResellerUsers");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.RoleMapper", b =>
                {
                    b.Property<int>("RoleMapperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleMapperId"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoleMapperId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("RoleMapper");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

<<<<<<<< HEAD:RedCloud.Persistenence/Migrations/20240613113128_conflicts-resolved.Designer.cs
========
            modelBuilder.Entity("OrganizationAdminResellerAdminUser", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.OrganizationAdmin", null)
                        .WithMany()
                        .HasForeignKey("OrganizationAdminsOrgID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedCloud.Domain.Entities.ResellerAdminUser", null)
                        .WithMany()
                        .HasForeignKey("ResellerAdminUsersResellerAdminUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.Campaign", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.OrganizationAdmin", "OrganizationAdmin")
                        .WithMany()
                        .HasForeignKey("OrganizationAdminOrgID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedCloud.Domain.Entities.ResellerAdminUser", "ResellerAdminUser")
                        .WithMany()
                        .HasForeignKey("ResellerAdminUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationAdmin");

                    b.Navigation("ResellerAdminUser");
                });

>>>>>>>> ResellerUser:RedCloud.Persistenence/Migrations/20240611110033_ResellerUser12.Designer.cs
            modelBuilder.Entity("RedCloud.Domain.Entities.City", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.OrganizationAdmin", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("RedCloud.Domain.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedCloud.Domain.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.OrganizationResellerMapping", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.OrganizationAdmin", "OrganizationAdmin")
                        .WithMany("OrganizationResellerMapping")
                        .HasForeignKey("OrganizationAdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedCloud.Domain.Entities.ResellerAdminUser", "ResellerAdminUser")
                        .WithMany("OrganizationResellerMapping")
                        .HasForeignKey("ResellerAdminUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationAdmin");

                    b.Navigation("ResellerAdminUser");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.OrganizationUser", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.OrganizationAdmin", "OrganizationAdmin")
                        .WithMany("OrganizationUsers")
                        .HasForeignKey("OrganizationAdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationAdmin");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.RedCloudAdmin", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.ResellerAdminUser", "ResellerAdminUsers")
                        .WithMany("RedCloudAdmins")
                        .HasForeignKey("ResellerAdminUserId");

                    b.Navigation("ResellerAdminUsers");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.ResellerAdminUser", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedCloud.Domain.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedCloud.Domain.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.ResellerUser", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.ResellerAdminUser", "ResellerAdminUser")
                        .WithMany("ResellerUser")
                        .HasForeignKey("ResellerAdminUserId");

                    b.Navigation("ResellerAdminUser");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.RoleMapper", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedCloud.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.State", b =>
                {
                    b.HasOne("RedCloud.Domain.Entities.Country", "Countries")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.OrganizationAdmin", b =>
                {
                    b.Navigation("OrganizationResellerMapping");

                    b.Navigation("OrganizationUsers");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.ResellerAdminUser", b =>
                {
                    b.Navigation("OrganizationResellerMapping");

                    b.Navigation("RedCloudAdmins");

                    b.Navigation("ResellerUser");
                });

            modelBuilder.Entity("RedCloud.Domain.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
