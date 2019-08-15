using Microsoft.EntityFrameworkCore.Migrations;

namespace Vendas.Migrations
{
    public partial class DepartmentChaveEstrangeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Department_departmentId",
                table: "Vendedor");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Vendedor",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Vendedor_departmentId",
                table: "Vendedor",
                newName: "IX_Vendedor_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Vendedor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Department_DepartmentId",
                table: "Vendedor",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Department_DepartmentId",
                table: "Vendedor");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Vendedor",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Vendedor_DepartmentId",
                table: "Vendedor",
                newName: "IX_Vendedor_departmentId");

            migrationBuilder.AlterColumn<int>(
                name: "departmentId",
                table: "Vendedor",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Department_departmentId",
                table: "Vendedor",
                column: "departmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
