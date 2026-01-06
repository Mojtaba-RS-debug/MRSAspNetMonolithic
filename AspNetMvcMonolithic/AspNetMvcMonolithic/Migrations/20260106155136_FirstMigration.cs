using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetMvcMonolithic.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Persons_PersonId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_PersonId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Product");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UnitPrice",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_PersonId",
                table: "Product",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Persons_PersonId",
                table: "Product",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
