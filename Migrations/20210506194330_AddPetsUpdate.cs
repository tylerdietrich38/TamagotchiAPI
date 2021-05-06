﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TamagotchiAPI.Migrations
{
    public partial class AddPetsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Scoldings_PetId",
                table: "Scoldings",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Playtimes_PetId",
                table: "Playtimes",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedings_PetId",
                table: "Feedings",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedings_Pets_PetId",
                table: "Feedings",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Playtimes_Pets_PetId",
                table: "Playtimes",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scoldings_Pets_PetId",
                table: "Scoldings",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedings_Pets_PetId",
                table: "Feedings");

            migrationBuilder.DropForeignKey(
                name: "FK_Playtimes_Pets_PetId",
                table: "Playtimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Scoldings_Pets_PetId",
                table: "Scoldings");

            migrationBuilder.DropIndex(
                name: "IX_Scoldings_PetId",
                table: "Scoldings");

            migrationBuilder.DropIndex(
                name: "IX_Playtimes_PetId",
                table: "Playtimes");

            migrationBuilder.DropIndex(
                name: "IX_Feedings_PetId",
                table: "Feedings");
        }
    }
}
