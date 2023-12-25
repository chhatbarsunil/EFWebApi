using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace EFWebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__efmigrationshistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    ProductVersion = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.MigrationId);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    empId = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    dept = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.empId);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    card_num = table.Column<long>(type: "bigint(20)", nullable: false),
                    card_cvc = table.Column<int>(type: "int(5)", nullable: false),
                    card_exp_month = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    card_exp_year = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    item_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    item_number = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    item_price = table.Column<float>(type: "float(10,2)", nullable: false),
                    item_price_currency = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, defaultValueSql: "'''''''usd'''''''"),
                    paid_amount = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    paid_amount_currency = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    txn_id = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    payment_status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, defaultValueSql: "'''NULL'''"),
                    password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, defaultValueSql: "'''NULL'''"),
                    firstname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, defaultValueSql: "'''NULL'''"),
                    lastname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, defaultValueSql: "'''NULL'''"),
                    address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, defaultValueSql: "'''NULL'''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__efmigrationshistory");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
