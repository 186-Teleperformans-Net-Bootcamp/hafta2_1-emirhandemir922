using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teleperformance._2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.id);
                    table.ForeignKey(
                        name: "FK_Courses_Classes_Classid",
                        column: x => x.Classid,
                        principalTable: "Classes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classid = table.Column<int>(type: "int", nullable: false),
                    Courseid = table.Column<int>(type: "int", nullable: true),
                    Schoolid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Teachers_Classes_Classid",
                        column: x => x.Classid,
                        principalTable: "Classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Courses_Courseid",
                        column: x => x.Courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Teachers_Schools_Schoolid",
                        column: x => x.Schoolid,
                        principalTable: "Schools",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    Schoolid = table.Column<int>(type: "int", nullable: false),
                    Classid = table.Column<int>(type: "int", nullable: false),
                    Courseid = table.Column<int>(type: "int", nullable: true),
                    Teacherid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_Classid",
                        column: x => x.Classid,
                        principalTable: "Classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Courses_Courseid",
                        column: x => x.Courseid,
                        principalTable: "Courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Students_Schools_Schoolid",
                        column: x => x.Schoolid,
                        principalTable: "Schools",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Teachers_Teacherid",
                        column: x => x.Teacherid,
                        principalTable: "Teachers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Classid",
                table: "Courses",
                column: "Classid");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Classid",
                table: "Students",
                column: "Classid");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Courseid",
                table: "Students",
                column: "Courseid");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Schoolid",
                table: "Students",
                column: "Schoolid");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Teacherid",
                table: "Students",
                column: "Teacherid");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Classid",
                table: "Teachers",
                column: "Classid");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Courseid",
                table: "Teachers",
                column: "Courseid");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Schoolid",
                table: "Teachers",
                column: "Schoolid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
