﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace kns.TourLand.Migrations
{
    public partial class AddEditionPaymentTypeToSubscriptionPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EditionPaymentType",
                table: "AppSubscriptionPayments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditionPaymentType",
                table: "AppSubscriptionPayments");
        }
    }
}
