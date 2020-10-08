using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactManagementSystem.Migrations
{
    public partial class RenamedContactsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactEntity",
                table: "ContactEntity");

            migrationBuilder.RenameTable(
                name: "ContactEntity",
                newName: "Contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "ContactEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactEntity",
                table: "ContactEntity",
                column: "Id");
        }
    }
}
