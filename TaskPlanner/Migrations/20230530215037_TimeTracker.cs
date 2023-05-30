using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskPlanner.Migrations
{
    /// <inheritdoc />
    public partial class TimeTracker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackedTime_Tasks_TaskId",
                table: "TrackedTime");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackedTime_Users_UserId",
                table: "TrackedTime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrackedTime",
                table: "TrackedTime");

            migrationBuilder.RenameTable(
                name: "TrackedTime",
                newName: "TrackedTimes");

            migrationBuilder.RenameIndex(
                name: "IX_TrackedTime_UserId",
                table: "TrackedTimes",
                newName: "IX_TrackedTimes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TrackedTime_TaskId",
                table: "TrackedTimes",
                newName: "IX_TrackedTimes_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrackedTimes",
                table: "TrackedTimes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedTimes_Tasks_TaskId",
                table: "TrackedTimes",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedTimes_Users_UserId",
                table: "TrackedTimes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackedTimes_Tasks_TaskId",
                table: "TrackedTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackedTimes_Users_UserId",
                table: "TrackedTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrackedTimes",
                table: "TrackedTimes");

            migrationBuilder.RenameTable(
                name: "TrackedTimes",
                newName: "TrackedTime");

            migrationBuilder.RenameIndex(
                name: "IX_TrackedTimes_UserId",
                table: "TrackedTime",
                newName: "IX_TrackedTime_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TrackedTimes_TaskId",
                table: "TrackedTime",
                newName: "IX_TrackedTime_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrackedTime",
                table: "TrackedTime",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedTime_Tasks_TaskId",
                table: "TrackedTime",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedTime_Users_UserId",
                table: "TrackedTime",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
