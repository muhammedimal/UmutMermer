using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UmutMermer.DataAccesLayer.Migrations
{
    public partial class change_named : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Companyİnfos",
                table: "Companyİnfos");

            migrationBuilder.RenameTable(
                name: "Companyİnfos",
                newName: "CompanyInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyInfos",
                table: "CompanyInfos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyInfos",
                table: "CompanyInfos");

            migrationBuilder.RenameTable(
                name: "CompanyInfos",
                newName: "Companyİnfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companyİnfos",
                table: "Companyİnfos",
                column: "Id");
        }
    }
}
