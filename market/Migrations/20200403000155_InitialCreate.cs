﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace market.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cloth",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false),
                    name = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(4000)", nullable: true),
                    price = table.Column<string>(type: "varchar(250)", nullable: false),
                    material = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cloth", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cloth");
        }
    }
}
