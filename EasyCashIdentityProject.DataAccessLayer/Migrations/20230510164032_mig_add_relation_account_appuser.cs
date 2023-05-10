using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class mig_add_relation_account_appuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AppUserID",
                table: "Accounts",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_AspNetUsers_AppUserID",
                table: "Accounts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AspNetUsers_AppUserID",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_AppUserID",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Accounts");
        }
    }
}
