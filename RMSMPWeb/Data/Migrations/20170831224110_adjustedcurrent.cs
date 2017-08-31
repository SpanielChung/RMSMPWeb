using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMSMPWeb.Data.Migrations
{
    public partial class adjustedcurrent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "compressorCurrentAjusted",
                table: "DataPoints",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "fanCurrentAjusted",
                table: "DataPoints",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "compressorCurrentAjusted",
                table: "DataPoints");

            migrationBuilder.DropColumn(
                name: "fanCurrentAjusted",
                table: "DataPoints");
        }
    }
}
