using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWorkHw2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Press",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Press", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDep = table.Column<int>(name: "Id_Dep", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Departments_Id_Dep",
                        column: x => x.IdDep,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdFacultity = table.Column<int>(name: "Id_Facultity", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groupss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groupss_Facultiess_Id_Facultity",
                        column: x => x.IdFacultity,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    YearPress = table.Column<int>(type: "int", nullable: false),
                    IdThemes = table.Column<int>(name: "Id_Themes", type: "int", nullable: false),
                    IdCategory = table.Column<int>(name: "Id_Category", type: "int", nullable: false),
                    IdAuthor = table.Column<int>(name: "Id_Author", type: "int", nullable: false),
                    IdPress = table.Column<int>(name: "Id_Press", type: "int", nullable: false),
                    Commennt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookss_Authorss_Id_Author",
                        column: x => x.IdAuthor,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookss_Categorys_Id_Category",
                        column: x => x.IdCategory,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookss_Presss_Id_Press",
                        column: x => x.IdPress,
                        principalTable: "Press",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookss_Themess_Id_Themes",
                        column: x => x.IdThemes,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdGroup = table.Column<int>(name: "Id_Group", type: "int", nullable: false),
                    Term = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studentss_Groupss_Id_Group",
                        column: x => x.IdGroup,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Cards",
                columns: table => new
                {
                    IdTeacher = table.Column<int>(name: "Id_Teacher", type: "int", nullable: false),
                    IdBooks = table.Column<int>(name: "Id_Books", type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLib = table.Column<int>(name: "Id_Lib", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_T_Cardss_Bookss_Id_Books",
                        column: x => x.IdBooks,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Cardss_Libss_Id_Lib",
                        column: x => x.IdLib,
                        principalTable: "Libs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Cardss_Teacherss_Id_Teacher",
                        column: x => x.IdTeacher,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "S_Cards",
                columns: table => new
                {
                    IdStudent = table.Column<int>(name: "Id_Student", type: "int", nullable: false),
                    IdBooks = table.Column<int>(name: "Id_Books", type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLib = table.Column<int>(name: "Id_Lib", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_S_Cardss_Bookss_Id_Books",
                        column: x => x.IdBooks,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_S_Cardss_Libss_Id_Lib",
                        column: x => x.IdLib,
                        principalTable: "Libs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_S_Cardss_Studentss_Id_Student",
                        column: x => x.IdStudent,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookss_Id_Author",
                table: "Books",
                column: "Id_Author");

            migrationBuilder.CreateIndex(
                name: "IX_Bookss_Id_Category",
                table: "Books",
                column: "Id_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Bookss_Id_Press",
                table: "Books",
                column: "Id_Press");

            migrationBuilder.CreateIndex(
                name: "IX_Bookss_Id_Themes",
                table: "Books",
                column: "Id_Themes");

            migrationBuilder.CreateIndex(
                name: "IX_Groupss_Id_Facultity",
                table: "Groups",
                column: "Id_Facultity");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cardss_Id_Books",
                table: "S_Cards",
                column: "Id_Books");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cardss_Id_Lib",
                table: "S_Cards",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cardss_Id_Student",
                table: "S_Cards",
                column: "Id_Student");

            migrationBuilder.CreateIndex(
                name: "IX_Studentss_Id_Group",
                table: "Students",
                column: "Id_Group");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cardss_Id_Books",
                table: "T_Cards",
                column: "Id_Books");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cardss_Id_Lib",
                table: "T_Cards",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cardss_Id_Teacher",
                table: "T_Cards",
                column: "Id_Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_Teacherss_Id_Dep",
                table: "Teachers",
                column: "Id_Dep");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "S_Cards");

            migrationBuilder.DropTable(
                name: "T_Cards");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Libs");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Press");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
