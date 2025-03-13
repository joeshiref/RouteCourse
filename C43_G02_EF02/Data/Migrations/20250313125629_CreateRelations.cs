using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G02_EF02.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TopicID",
                table: "CoursesTable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_Id",
                table: "Students",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourses_Course_ID",
                table: "StudCourses",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesTable_TopicID",
                table: "CoursesTable",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructors_Course_ID",
                table: "CourseInstructors",
                column: "Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_CoursesTable_Course_ID",
                table: "CourseInstructors",
                column: "Course_ID",
                principalTable: "CoursesTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructors_Instructors_Inst_ID",
                table: "CourseInstructors",
                column: "Inst_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesTable_TopicsTable_TopicID",
                table: "CoursesTable",
                column: "TopicID",
                principalTable: "TopicsTable",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_DepartmentTable_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "DepartmentTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_CoursesTable_Course_ID",
                table: "StudCourses",
                column: "Course_ID",
                principalTable: "CoursesTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourses_Students_Stud_ID",
                table: "StudCourses",
                column: "Stud_ID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_DepartmentTable_Dep_Id",
                table: "Students",
                column: "Dep_Id",
                principalTable: "DepartmentTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_CoursesTable_Course_ID",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructors_Instructors_Inst_ID",
                table: "CourseInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesTable_TopicsTable_TopicID",
                table: "CoursesTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_DepartmentTable_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_CoursesTable_Course_ID",
                table: "StudCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourses_Students_Stud_ID",
                table: "StudCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_DepartmentTable_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudCourses_Course_ID",
                table: "StudCourses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_CoursesTable_TopicID",
                table: "CoursesTable");

            migrationBuilder.DropIndex(
                name: "IX_CourseInstructors_Course_ID",
                table: "CourseInstructors");

            migrationBuilder.DropColumn(
                name: "TopicID",
                table: "CoursesTable");
        }
    }
}
