using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ibp_portal_server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity_logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reference_id = table.Column<int>(type: "int", nullable: false),
                    reference_type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employment_sectors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment_sectors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Government_ids",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Government_ids", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ibp_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ibp_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    content = table.Column<string>(type: "ntext", nullable: false),
                    notification_type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    origin_id = table.Column<int>(type: "int", nullable: false),
                    destination_id = table.Column<int>(type: "int", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Payment_channels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_channels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Recruitment_channels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruitment_channels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User_logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reference_id = table.Column<int>(type: "int", nullable: false),
                    reference_type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    date_signed_in = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_signed_out = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Account_statuses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reference_id = table.Column<int>(type: "int", nullable: false),
                    reference_type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account_statuses", x => x.id);
                    table.ForeignKey(
                        name: "FK_Account_statuses_Statuses_status_id",
                        column: x => x.status_id,
                        principalTable: "Statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ibps",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    middle_name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    suffix = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    contact_no = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    tin_no = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    civil_status = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    employment_status = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    occupation_business = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    recruiter_sponsor = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    requirements_due_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    attachment_profile_id = table.Column<byte[]>(type: "image", nullable: false),
                    attachment_government_id = table.Column<byte[]>(type: "image", nullable: false),
                    attachment_government_selfie_id = table.Column<byte[]>(type: "image", nullable: false),
                    attachment_personal_id = table.Column<byte[]>(type: "image", nullable: false),
                    attachment_signature_id = table.Column<byte[]>(type: "image", nullable: false),
                    attachment_gcash_id = table.Column<byte[]>(type: "image", nullable: false),
                    ibp_type_id = table.Column<int>(type: "int", nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    government_id = table.Column<int>(type: "int", nullable: false),
                    recruitment_channel_id = table.Column<int>(type: "int", nullable: false),
                    employment_sector_id = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ibps", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ibps_Branches_branch_id",
                        column: x => x.branch_id,
                        principalTable: "Branches",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ibps_Employment_sectors_employment_sector_id",
                        column: x => x.employment_sector_id,
                        principalTable: "Employment_sectors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ibps_Government_ids_government_id",
                        column: x => x.government_id,
                        principalTable: "Government_ids",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ibps_Ibp_types_ibp_type_id",
                        column: x => x.ibp_type_id,
                        principalTable: "Ibp_types",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ibps_Recruitment_channels_recruitment_channel_id",
                        column: x => x.recruitment_channel_id,
                        principalTable: "Recruitment_channels",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ibps_Statuses_status_id",
                        column: x => x.status_id,
                        principalTable: "Statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Branches_branch_id",
                        column: x => x.branch_id,
                        principalTable: "Branches",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Users_Roles_role_id",
                        column: x => x.role_id,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Statuses_status_id",
                        column: x => x.status_id,
                        principalTable: "Statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Corporate_affiliates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ibp_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    relationship = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    position = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    rank = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporate_affiliates", x => x.id);
                    table.ForeignKey(
                        name: "FK_Corporate_affiliates_Ibps_ibp_id",
                        column: x => x.ibp_id,
                        principalTable: "Ibps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emergency_contacts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ibp_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    relationship = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    contact_no = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Ibpid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergency_contacts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Emergency_contacts_Ibps_Ibpid",
                        column: x => x.Ibpid,
                        principalTable: "Ibps",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Emergency_contacts_Ibps_ibp_id",
                        column: x => x.ibp_id,
                        principalTable: "Ibps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment_methods",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ibp_id = table.Column<int>(type: "int", nullable: false),
                    payment_channel_id = table.Column<int>(type: "int", nullable: false),
                    card_no = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    account_no = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_methods", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payment_methods_Ibps_ibp_id",
                        column: x => x.ibp_id,
                        principalTable: "Ibps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_methods_Payment_channels_payment_channel_id",
                        column: x => x.payment_channel_id,
                        principalTable: "Payment_channels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_methods_Statuses_status_id",
                        column: x => x.status_id,
                        principalTable: "Statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ibp_registrations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ibp_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    confirmed_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ibp_registrations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ibp_registrations_Ibps_ibp_id",
                        column: x => x.ibp_id,
                        principalTable: "Ibps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ibp_registrations_Roles_role_id",
                        column: x => x.role_id,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ibp_registrations_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_statuses_status_id",
                table: "Account_statuses",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Corporate_affiliates_ibp_id",
                table: "Corporate_affiliates",
                column: "ibp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Emergency_contacts_ibp_id",
                table: "Emergency_contacts",
                column: "ibp_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emergency_contacts_Ibpid",
                table: "Emergency_contacts",
                column: "Ibpid");

            migrationBuilder.CreateIndex(
                name: "IX_Ibp_registrations_ibp_id",
                table: "Ibp_registrations",
                column: "ibp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibp_registrations_role_id",
                table: "Ibp_registrations",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibp_registrations_user_id",
                table: "Ibp_registrations",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibps_branch_id",
                table: "Ibps",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibps_employment_sector_id",
                table: "Ibps",
                column: "employment_sector_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibps_government_id",
                table: "Ibps",
                column: "government_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibps_ibp_type_id",
                table: "Ibps",
                column: "ibp_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibps_recruitment_channel_id",
                table: "Ibps",
                column: "recruitment_channel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibps_status_id",
                table: "Ibps",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_methods_ibp_id",
                table: "Payment_methods",
                column: "ibp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_methods_payment_channel_id",
                table: "Payment_methods",
                column: "payment_channel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_methods_status_id",
                table: "Payment_methods",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_branch_id",
                table: "Users",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_role_id",
                table: "Users",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_status_id",
                table: "Users",
                column: "status_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account_statuses");

            migrationBuilder.DropTable(
                name: "Activity_logs");

            migrationBuilder.DropTable(
                name: "Corporate_affiliates");

            migrationBuilder.DropTable(
                name: "Emergency_contacts");

            migrationBuilder.DropTable(
                name: "Ibp_registrations");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Payment_methods");

            migrationBuilder.DropTable(
                name: "User_logs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Ibps");

            migrationBuilder.DropTable(
                name: "Payment_channels");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Employment_sectors");

            migrationBuilder.DropTable(
                name: "Government_ids");

            migrationBuilder.DropTable(
                name: "Ibp_types");

            migrationBuilder.DropTable(
                name: "Recruitment_channels");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
