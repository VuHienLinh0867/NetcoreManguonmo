using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetcoreManguonmo.Migrations
{
    public partial class Create_Table_Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangID",
                table: "HoaDons");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "HoaDons",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "KhachHangID",
                table: "HoaDons",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangID",
                table: "HoaDons",
                column: "KhachHangID",
                principalTable: "KhachHangs",
                principalColumn: "KhachHangID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangID",
                table: "HoaDons");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "HoaDons",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KhachHangID",
                table: "HoaDons",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangID",
                table: "HoaDons",
                column: "KhachHangID",
                principalTable: "KhachHangs",
                principalColumn: "KhachHangID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
