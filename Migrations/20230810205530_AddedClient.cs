using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HW3_module4.Migrations
{
    /// <inheritdoc />
    public partial class AddedClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeProjects",
                table: "EmployeeProjects");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects");

            migrationBuilder.DropColumn(
                name: "EmployeeProjectId",
                table: "EmployeeProjects");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeProjects",
                table: "EmployeeProjects",
                columns: new[] { "EmployeeId", "ProjectId" });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Age", "County", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 10, 35, "Ukraine", "Ivan", "Ivanov" },
                    { 11, 25, "Armenia", "Tyson", "Mike" },
                    { 12, 37, "Ukraine", "Korobka", "Petr" },
                    { 13, 28, "Ukraine", "Mex", "Artem" },
                    { 14, 44, "Ireland", "Jon", "Jons" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartDate" },
                values: new object[,]
                {
                    { 10, 24561m, 10, "Instagram", new DateTime(2014, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 55665m, 11, "Mono", new DateTime(2016, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 1542m, 12, "Onet", new DateTime(2018, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 846454m, 13, "Booolb", new DateTime(2010, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 4894m, 14, "Ms", new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ClientId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeProjects",
                table: "EmployeeProjects");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeProjectId",
                table: "EmployeeProjects",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeProjects",
                table: "EmployeeProjects",
                column: "EmployeeProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId");
        }
    }
}
