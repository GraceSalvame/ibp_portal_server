using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ibp_portal_server.Migrations
{
    /// <inheritdoc />
    public partial class allmodule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "requirements_due_date",
                table: "Ibps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Ibps",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "contact_no",
                table: "Ibps",
                type: "nvarchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.CreateTable(
                name: "Nature_of_requests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nature_of_requests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Payout_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payout_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Request_specifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    nature_of_request_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request_specifications", x => x.id);
                    table.ForeignKey(
                        name: "FK_Request_specifications_Nature_of_requests_nature_of_request_id",
                        column: x => x.nature_of_request_id,
                        principalTable: "Nature_of_requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payment_type_id = table.Column<int>(type: "int", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payments_Payout_types_payment_type_id",
                        column: x => x.payment_type_id,
                        principalTable: "Payout_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "request_sub_specifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    request_specification_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_request_sub_specifications", x => x.id);
                    table.ForeignKey(
                        name: "FK_request_sub_specifications_Request_specifications_request_specification_id",
                        column: x => x.request_specification_id,
                        principalTable: "Request_specifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ibp_id = table.Column<int>(type: "int", nullable: false),
                    payment_id = table.Column<int>(type: "int", nullable: false),
                    sale_type = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    account_code = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    customer_code = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    sales_invoice_no = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    sales_invoice_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_amount = table.Column<int>(type: "int", nullable: false),
                    total_deduction = table.Column<int>(type: "int", nullable: false),
                    total_net_amount = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payment_details_Ibps_ibp_id",
                        column: x => x.ibp_id,
                        principalTable: "Ibps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_details_Payments_payment_id",
                        column: x => x.payment_id,
                        principalTable: "Payments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_details_Statuses_status_id",
                        column: x => x.status_id,
                        principalTable: "Statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment_transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payment_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    Role_id = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    date_confirmed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_transactions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payment_transactions_Payments_payment_id",
                        column: x => x.payment_id,
                        principalTable: "Payments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_transactions_Roles_Role_id",
                        column: x => x.Role_id,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_transactions_Statuses_status_id",
                        column: x => x.status_id,
                        principalTable: "Statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_transactions_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ibp_id = table.Column<int>(type: "int", nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    nature_of_request_id = table.Column<int>(type: "int", nullable: false),
                    request_specification_id = table.Column<int>(type: "int", nullable: false),
                    request_sub_specification_id = table.Column<int>(type: "int", nullable: false),
                    reference_id = table.Column<int>(type: "int", nullable: false),
                    reference_type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.id);
                    table.ForeignKey(
                        name: "FK_Requests_Branches_branch_id",
                        column: x => x.branch_id,
                        principalTable: "Branches",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Ibps_ibp_id",
                        column: x => x.ibp_id,
                        principalTable: "Ibps",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Requests_Nature_of_requests_nature_of_request_id",
                        column: x => x.nature_of_request_id,
                        principalTable: "Nature_of_requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Request_specifications_request_specification_id",
                        column: x => x.request_specification_id,
                        principalTable: "Request_specifications",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Requests_Statuses_status_id",
                        column: x => x.status_id,
                        principalTable: "Statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_request_sub_specifications_request_sub_specification_id",
                        column: x => x.request_sub_specification_id,
                        principalTable: "request_sub_specifications",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Card_replenishments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card_replenishments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Card_replenishments_Requests_request_id",
                        column: x => x.request_id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ibp_information_updates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request_id = table.Column<int>(type: "int", nullable: false),
                    prev_firstname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    prev_middle_name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    prev_lastname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    prev_suffix = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    prev_contact_no = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    prev_email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    prev_password = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    prev_tin_no = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    prev_gender = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    prev_birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prev_civil_status = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    prev_employment_status = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    prev_occupation_business = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    prev_recruiter_sponsor = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    prev_requirements_due_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prev_attachment_profile_id = table.Column<byte[]>(type: "image", nullable: false),
                    prev_attachment_government_id = table.Column<byte[]>(type: "image", nullable: false),
                    prev_attachment_government_selfie_id = table.Column<byte[]>(type: "image", nullable: false),
                    prev_attachment_personal_id = table.Column<byte[]>(type: "image", nullable: false),
                    prev_attachment_signature_id = table.Column<byte[]>(type: "image", nullable: false),
                    prev_attachment_gcash_id = table.Column<byte[]>(type: "image", nullable: false),
                    prev_ibp_type_id = table.Column<int>(type: "int", nullable: false),
                    prev_branch_id = table.Column<int>(type: "int", nullable: false),
                    prev_government_id = table.Column<int>(type: "int", nullable: false),
                    prev_recruitment_channel_id = table.Column<int>(type: "int", nullable: false),
                    prev_employment_sector_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ibp_information_updates", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ibp_information_updates_Branches_prev_branch_id",
                        column: x => x.prev_branch_id,
                        principalTable: "Branches",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ibp_information_updates_Employment_sectors_prev_employment_sector_id",
                        column: x => x.prev_employment_sector_id,
                        principalTable: "Employment_sectors",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ibp_information_updates_Government_ids_prev_government_id",
                        column: x => x.prev_government_id,
                        principalTable: "Government_ids",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ibp_information_updates_Ibp_types_prev_ibp_type_id",
                        column: x => x.prev_ibp_type_id,
                        principalTable: "Ibp_types",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ibp_information_updates_Recruitment_channels_prev_recruitment_channel_id",
                        column: x => x.prev_recruitment_channel_id,
                        principalTable: "Recruitment_channels",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ibp_information_updates_Requests_request_id",
                        column: x => x.request_id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lost_cash_card_deactivations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request_id = table.Column<int>(type: "int", nullable: false),
                    cash_card_number = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    physically_collected_cash_card = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lost_cash_card_deactivations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Lost_cash_card_deactivations_Requests_request_id",
                        column: x => x.request_id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lost_cash_card_fund_transfers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request_id = table.Column<int>(type: "int", nullable: false),
                    prev_cash_card_no = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    prev_cash_card_account_no = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    new_cash_card_no = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    new_cash_card_account_no = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lost_cash_card_fund_transfers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Lost_cash_card_fund_transfers_Requests_request_id",
                        column: x => x.request_id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lost_cash_card_replacements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lost_cash_card_replacements", x => x.id);
                    table.ForeignKey(
                        name: "FK_Lost_cash_card_replacements_Requests_request_id",
                        column: x => x.request_id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mailer_pins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request_id = table.Column<int>(type: "int", nullable: false),
                    card_number = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    card_account_number = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mailer_pins", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mailer_pins_Requests_request_id",
                        column: x => x.request_id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payout_related_concerns",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request_id = table.Column<int>(type: "int", nullable: false),
                    customer_code = table.Column<int>(type: "int", nullable: false),
                    customer_name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    account_code = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    sales_invoice_no = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    sales_invoice_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    justification = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payout_related_concerns", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payout_related_concerns_Requests_request_id",
                        column: x => x.request_id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Request_transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    request_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    remarks = table.Column<string>(type: "ntext", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request_transactions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Request_transactions_Requests_request_id",
                        column: x => x.request_id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_transactions_Roles_role_id",
                        column: x => x.role_id,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_transactions_Statuses_status_id",
                        column: x => x.status_id,
                        principalTable: "Statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Request_transactions_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Payout_related_concern_specifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    payout_related_concern_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payout_related_concern_specifications", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payout_related_concern_specifications_Payout_related_concerns_payout_related_concern_id",
                        column: x => x.payout_related_concern_id,
                        principalTable: "Payout_related_concerns",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payout_related_concern_sub_pecifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    description = table.Column<string>(type: "ntext", nullable: false),
                    payout_related_concern_specification_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payout_related_concern_sub_pecifications", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payout_related_concern_sub_pecifications_Payout_related_concern_specifications_payout_related_concern_specification_id",
                        column: x => x.payout_related_concern_specification_id,
                        principalTable: "Payout_related_concern_specifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_replenishments_request_id",
                table: "Card_replenishments",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibp_information_updates_prev_branch_id",
                table: "Ibp_information_updates",
                column: "prev_branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibp_information_updates_prev_employment_sector_id",
                table: "Ibp_information_updates",
                column: "prev_employment_sector_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibp_information_updates_prev_government_id",
                table: "Ibp_information_updates",
                column: "prev_government_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibp_information_updates_prev_ibp_type_id",
                table: "Ibp_information_updates",
                column: "prev_ibp_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibp_information_updates_prev_recruitment_channel_id",
                table: "Ibp_information_updates",
                column: "prev_recruitment_channel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ibp_information_updates_request_id",
                table: "Ibp_information_updates",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Lost_cash_card_deactivations_request_id",
                table: "Lost_cash_card_deactivations",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Lost_cash_card_fund_transfers_request_id",
                table: "Lost_cash_card_fund_transfers",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Lost_cash_card_replacements_request_id",
                table: "Lost_cash_card_replacements",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Mailer_pins_request_id",
                table: "Mailer_pins",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_details_ibp_id",
                table: "Payment_details",
                column: "ibp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_details_payment_id",
                table: "Payment_details",
                column: "payment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_details_status_id",
                table: "Payment_details",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_transactions_payment_id",
                table: "Payment_transactions",
                column: "payment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_transactions_Role_id",
                table: "Payment_transactions",
                column: "Role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_transactions_status_id",
                table: "Payment_transactions",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_transactions_user_id",
                table: "Payment_transactions",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_payment_type_id",
                table: "Payments",
                column: "payment_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payout_related_concern_specifications_payout_related_concern_id",
                table: "Payout_related_concern_specifications",
                column: "payout_related_concern_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payout_related_concern_sub_pecifications_payout_related_concern_specification_id",
                table: "Payout_related_concern_sub_pecifications",
                column: "payout_related_concern_specification_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payout_related_concerns_request_id",
                table: "Payout_related_concerns",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Request_specifications_nature_of_request_id",
                table: "Request_specifications",
                column: "nature_of_request_id");

            migrationBuilder.CreateIndex(
                name: "IX_request_sub_specifications_request_specification_id",
                table: "request_sub_specifications",
                column: "request_specification_id");

            migrationBuilder.CreateIndex(
                name: "IX_Request_transactions_request_id",
                table: "Request_transactions",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Request_transactions_role_id",
                table: "Request_transactions",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Request_transactions_status_id",
                table: "Request_transactions",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Request_transactions_user_id",
                table: "Request_transactions",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_branch_id",
                table: "Requests",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ibp_id",
                table: "Requests",
                column: "ibp_id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_nature_of_request_id",
                table: "Requests",
                column: "nature_of_request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_request_specification_id",
                table: "Requests",
                column: "request_specification_id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_request_sub_specification_id",
                table: "Requests",
                column: "request_sub_specification_id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_status_id",
                table: "Requests",
                column: "status_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card_replenishments");

            migrationBuilder.DropTable(
                name: "Ibp_information_updates");

            migrationBuilder.DropTable(
                name: "Lost_cash_card_deactivations");

            migrationBuilder.DropTable(
                name: "Lost_cash_card_fund_transfers");

            migrationBuilder.DropTable(
                name: "Lost_cash_card_replacements");

            migrationBuilder.DropTable(
                name: "Mailer_pins");

            migrationBuilder.DropTable(
                name: "Payment_details");

            migrationBuilder.DropTable(
                name: "Payment_transactions");

            migrationBuilder.DropTable(
                name: "Payout_related_concern_sub_pecifications");

            migrationBuilder.DropTable(
                name: "Request_transactions");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Payout_related_concern_specifications");

            migrationBuilder.DropTable(
                name: "Payout_types");

            migrationBuilder.DropTable(
                name: "Payout_related_concerns");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "request_sub_specifications");

            migrationBuilder.DropTable(
                name: "Request_specifications");

            migrationBuilder.DropTable(
                name: "Nature_of_requests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "requirements_due_date",
                table: "Ibps",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Ibps",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "contact_no",
                table: "Ibps",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)");
        }
    }
}
