using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RMSMPWeb.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "DataPoints",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    compressionTemp = table.Column<double>(nullable: false),
                    compressorCurrent = table.Column<double>(nullable: false),
                    condensorTemp = table.Column<double>(nullable: false),
                    deviceId = table.Column<string>(nullable: true),
                    dischargeAirHumidity = table.Column<double>(nullable: false),
                    dischargeAirTemp = table.Column<double>(nullable: false),
                    evaporatorTemp = table.Column<double>(nullable: false),
                    fanCurrent = table.Column<double>(nullable: false),
                    groupingStamp = table.Column<DateTime>(nullable: false),
                    returnAirHumidity = table.Column<double>(nullable: false),
                    returnAirTemp = table.Column<double>(nullable: false),
                    sourceCount = table.Column<int>(nullable: false),
                    suctionTemp = table.Column<double>(nullable: false),
                    timeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPoints", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataPoints");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
