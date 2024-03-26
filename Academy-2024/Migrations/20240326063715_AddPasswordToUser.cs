using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academy_2024.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "courses");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Courses");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Users",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Courses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CourseUser",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUser", x => new { x.CoursesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CourseUser_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_UsersId",
                table: "CourseUser",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "courses");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "DateOfBirth");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "courses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "courses",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "Id");
        }
    }
}
