using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tech.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConfirmPassword", "CreateDate", "Email", "Password", "UpdatedDate" },
                values: new object[] { 1, "123456", new DateTime(2022, 7, 29, 22, 16, 30, 892, DateTimeKind.Local).AddTicks(2167), "emre11@gmail.com", "123456", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConfirmPassword", "CreateDate", "Email", "Password", "UpdatedDate" },
                values: new object[] { 2, "123456", new DateTime(2022, 7, 29, 22, 16, 30, 892, DateTimeKind.Local).AddTicks(2181), "ahmet@gmail.com", "123456", null });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Body", "CreateDate", "Title", "UpdatedDate", "UserId" },
                values: new object[] { 1, "Body 1", new DateTime(2022, 7, 29, 22, 16, 30, 892, DateTimeKind.Local).AddTicks(2287), "Title 1 ", null, 1 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Body", "CreateDate", "Title", "UpdatedDate", "UserId" },
                values: new object[] { 2, "Body 2", new DateTime(2022, 7, 29, 22, 16, 30, 892, DateTimeKind.Local).AddTicks(2290), "Title 2 ", null, 2 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Body", "CreateDate", "Title", "UpdatedDate", "UserId" },
                values: new object[] { 3, "Body 3", new DateTime(2022, 7, 29, 22, 16, 30, 892, DateTimeKind.Local).AddTicks(2291), "Title 3 ", null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
