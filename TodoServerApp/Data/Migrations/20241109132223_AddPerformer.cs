using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPerformer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPerformer",
                table: "TaskItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PerformerItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pantronymic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformerItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PerformerItems",
                columns: new[] { "Id", "Name", "Pantronymic", "Surname" },
                values: new object[,]
                {
                    { 1, "Кирилл", "Романович", "Полещук" },
                    { 2, "Андрей", "Витальевич", "Соломонов" }
                });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IdPerformer" },
                values: new object[] { new DateTime(2024, 11, 9, 18, 22, 23, 607, DateTimeKind.Local).AddTicks(4772), 1 });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IdPerformer" },
                values: new object[] { new DateTime(2024, 11, 9, 18, 22, 23, 607, DateTimeKind.Local).AddTicks(4782), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IdPerformer" },
                values: new object[] { new DateTime(2024, 11, 9, 18, 22, 23, 607, DateTimeKind.Local).AddTicks(4784), 2 });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IdPerformer" },
                values: new object[] { new DateTime(2024, 11, 9, 18, 22, 23, 607, DateTimeKind.Local).AddTicks(4785), null });

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_IdPerformer",
                table: "TaskItems",
                column: "IdPerformer");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_PerformerItems_IdPerformer",
                table: "TaskItems",
                column: "IdPerformer",
                principalTable: "PerformerItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_PerformerItems_IdPerformer",
                table: "TaskItems");

            migrationBuilder.DropTable(
                name: "PerformerItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_IdPerformer",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "IdPerformer",
                table: "TaskItems");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 19, 5, 35, 952, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 19, 5, 35, 952, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 19, 5, 35, 952, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 20, 19, 5, 35, 952, DateTimeKind.Local).AddTicks(4365));
        }
    }
}
