using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blood.Migrations.InventoryDb
{
    public partial class CreateInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "inventory",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_by = table.Column<string>(nullable: true),
                    serial_no = table.Column<string>(nullable: true),
                    qty = table.Column<int>(nullable: false),
                    mbd = table.Column<string>(nullable: true),
                    blood_type = table.Column<string>(nullable: true),
                    date_coltd = table.Column<DateTime>(nullable: false),
                    date_released = table.Column<DateTime>(nullable: false),
                    stakeholder = table.Column<string>(nullable: true),
                    date_transfuse = table.Column<DateTime>(nullable: false),
                    key_test = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    expiry_date = table.Column<DateTime>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    amount = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventory");
        }
    }
}
