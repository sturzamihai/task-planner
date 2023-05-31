using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskPlanner.Migrations
{
    /// <inheritdoc />
    public partial class Refactor1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AsigneeId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Interval",
                table: "TrackedTime");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TaskStatus",
                newName: "Title");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "TrackedTime",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "TrackedTime",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "AsigneeId",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AsigneeId",
                table: "Tasks",
                column: "AsigneeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AsigneeId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "TrackedTime");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "TrackedTime");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TaskStatus",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Interval",
                table: "TrackedTime",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AsigneeId",
                table: "Tasks",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AsigneeId",
                table: "Tasks",
                column: "AsigneeId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
