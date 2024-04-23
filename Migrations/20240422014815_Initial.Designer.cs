﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ibp_portal_server.Context;

#nullable disable

namespace ibp_portal_server.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240422014815_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ibp_portal_server.Model.Account_status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<int>("reference_id")
                        .HasColumnType("int");

                    b.Property<string>("reference_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("status_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("status_id");

                    b.ToTable("Account_statuses");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Activity_log", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<int>("reference_id")
                        .HasColumnType("int");

                    b.Property<string>("reference_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.ToTable("Activity_logs");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Branch", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Corporate_affiliate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("ibp_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("rank")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("relationship")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("ibp_id");

                    b.ToTable("Corporate_affiliates");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Emergency_contact", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Ibpid")
                        .HasColumnType("int");

                    b.Property<string>("contact_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ibp_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("relationship")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("Ibpid");

                    b.HasIndex("ibp_id")
                        .IsUnique();

                    b.ToTable("Emergency_contacts");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Employment_sector", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Employment_sectors");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Government_id", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Government_ids");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Ibp", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<byte[]>("attachment_gcash_id")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<byte[]>("attachment_government_id")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<byte[]>("attachment_government_selfie_id")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<byte[]>("attachment_personal_id")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<byte[]>("attachment_profile_id")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<byte[]>("attachment_signature_id")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("branch_id")
                        .HasColumnType("int");

                    b.Property<string>("civil_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("contact_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("employment_sector_id")
                        .HasColumnType("int");

                    b.Property<string>("employment_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("government_id")
                        .HasColumnType("int");

                    b.Property<int>("ibp_type_id")
                        .HasColumnType("int");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("middle_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("occupation_business")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("recruiter_sponsor")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("recruitment_channel_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("requirements_due_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("status_id")
                        .HasColumnType("int");

                    b.Property<string>("suffix")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("tin_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("branch_id");

                    b.HasIndex("employment_sector_id");

                    b.HasIndex("government_id");

                    b.HasIndex("ibp_type_id");

                    b.HasIndex("recruitment_channel_id");

                    b.HasIndex("status_id");

                    b.ToTable("Ibps");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Ibp_registration", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("confirmed_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ibp_id")
                        .HasColumnType("int");

                    b.Property<int>("role_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ibp_id");

                    b.HasIndex("role_id");

                    b.HasIndex("user_id");

                    b.ToTable("Ibp_registrations");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Ibp_type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Ibp_types");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Notification", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<int>("destination_id")
                        .HasColumnType("int");

                    b.Property<string>("notification_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("origin_id")
                        .HasColumnType("int");

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Payment_channel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Payment_channels");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Payment_method", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("account_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("card_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("ibp_id")
                        .HasColumnType("int");

                    b.Property<int>("payment_channel_id")
                        .HasColumnType("int");

                    b.Property<int>("status_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ibp_id");

                    b.HasIndex("payment_channel_id");

                    b.HasIndex("status_id");

                    b.ToTable("Payment_methods");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Recruitment_channel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Recruitment_channels");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("ibp_portal_server.Model.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("branch_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_created")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("role_id")
                        .HasColumnType("int");

                    b.Property<int>("status_id")
                        .HasColumnType("int");

                    b.Property<int?>("user_id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("branch_id");

                    b.HasIndex("role_id");

                    b.HasIndex("status_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ibp_portal_server.Model.User_log", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("date_signed_in")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("date_signed_out")
                        .HasColumnType("datetime2");

                    b.Property<int>("reference_id")
                        .HasColumnType("int");

                    b.Property<string>("reference_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("User_logs");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Account_status", b =>
                {
                    b.HasOne("ibp_portal_server.Model.Status", "Status")
                        .WithMany("Account_statuses")
                        .HasForeignKey("status_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Corporate_affiliate", b =>
                {
                    b.HasOne("ibp_portal_server.Model.Ibp", "Ibp")
                        .WithMany("Corporate_affiliates")
                        .HasForeignKey("ibp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ibp");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Emergency_contact", b =>
                {
                    b.HasOne("ibp_portal_server.Model.Ibp", null)
                        .WithMany("Emergency_Contacts")
                        .HasForeignKey("Ibpid");

                    b.HasOne("ibp_portal_server.Model.Ibp", "Ibp")
                        .WithOne()
                        .HasForeignKey("ibp_portal_server.Model.Emergency_contact", "ibp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ibp");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Ibp", b =>
                {
                    b.HasOne("ibp_portal_server.Model.Branch", "Branch")
                        .WithMany("Ibps")
                        .HasForeignKey("branch_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ibp_portal_server.Model.Employment_sector", "Employment_sector")
                        .WithMany("Ibps")
                        .HasForeignKey("employment_sector_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ibp_portal_server.Model.Government_id", "Government_id")
                        .WithMany("Ibps")
                        .HasForeignKey("government_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ibp_portal_server.Model.Ibp_type", "Ibp_type")
                        .WithMany("Ibps")
                        .HasForeignKey("ibp_type_id");

                    b.HasOne("ibp_portal_server.Model.Recruitment_channel", "Recruitment_channel")
                        .WithMany("Ibps")
                        .HasForeignKey("recruitment_channel_id");

                    b.HasOne("ibp_portal_server.Model.Status", "Status")
                        .WithMany("Ibps")
                        .HasForeignKey("status_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Employment_sector");

                    b.Navigation("Government_id");

                    b.Navigation("Ibp_type");

                    b.Navigation("Recruitment_channel");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Ibp_registration", b =>
                {
                    b.HasOne("ibp_portal_server.Model.Ibp", "Ibp")
                        .WithMany("Ibp_registrations")
                        .HasForeignKey("ibp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ibp_portal_server.Model.Role", "Role")
                        .WithMany("Ibp_registrations")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ibp_portal_server.Model.User", "User")
                        .WithMany("Ibp_registrations")
                        .HasForeignKey("user_id");

                    b.Navigation("Ibp");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Payment_method", b =>
                {
                    b.HasOne("ibp_portal_server.Model.Ibp", "Ibp")
                        .WithMany("Payment_Methods")
                        .HasForeignKey("ibp_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ibp_portal_server.Model.Payment_channel", "Payment_channel")
                        .WithMany("Payment_Methods")
                        .HasForeignKey("payment_channel_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ibp_portal_server.Model.Status", "Status")
                        .WithMany("Payment_Methods")
                        .HasForeignKey("status_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ibp");

                    b.Navigation("Payment_channel");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ibp_portal_server.Model.User", b =>
                {
                    b.HasOne("ibp_portal_server.Model.Branch", "Branch")
                        .WithMany("Users")
                        .HasForeignKey("branch_id");

                    b.HasOne("ibp_portal_server.Model.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ibp_portal_server.Model.Status", "Status")
                        .WithMany("Users")
                        .HasForeignKey("status_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Role");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Branch", b =>
                {
                    b.Navigation("Ibps");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Employment_sector", b =>
                {
                    b.Navigation("Ibps");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Government_id", b =>
                {
                    b.Navigation("Ibps");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Ibp", b =>
                {
                    b.Navigation("Corporate_affiliates");

                    b.Navigation("Emergency_Contacts");

                    b.Navigation("Ibp_registrations");

                    b.Navigation("Payment_Methods");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Ibp_type", b =>
                {
                    b.Navigation("Ibps");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Payment_channel", b =>
                {
                    b.Navigation("Payment_Methods");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Recruitment_channel", b =>
                {
                    b.Navigation("Ibps");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Role", b =>
                {
                    b.Navigation("Ibp_registrations");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ibp_portal_server.Model.Status", b =>
                {
                    b.Navigation("Account_statuses");

                    b.Navigation("Ibps");

                    b.Navigation("Payment_Methods");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ibp_portal_server.Model.User", b =>
                {
                    b.Navigation("Ibp_registrations");
                });
#pragma warning restore 612, 618
        }
    }
}