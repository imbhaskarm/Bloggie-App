using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class secondAuthDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1374ab7b-c7c6-4efc-ac08-7698d15e9ba9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e1d21a1-5dd0-4b4c-93f3-6f668d97e7f5", "AQAAAAIAAYagAAAAEO2H/+B247X4xkF6isKZq6LM734hlaoiwYmrGAIAYqz39seVvZt1Uf85ACtaZ+vhJQ==", "b70b9267-6d3e-48ea-b826-2beed33e56cf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1374ab7b-c7c6-4efc-ac08-7698d15e9ba9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f6aa8da-e61c-4112-8bff-26bb080421c1", "AQAAAAIAAYagAAAAEL3RJwpf16DS5lxgKP7nDmhQWn18E0Ma+y4XN7SbsiwUhIuM5oIGwhrC2KLpjtlPqA==", "94d863c9-fad4-4145-a095-06c9560091a6" });
        }
    }
}
