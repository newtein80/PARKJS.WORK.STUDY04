using Microsoft.EntityFrameworkCore.Migrations;

namespace PARKJS.WORK.STUDY04.Data.Migrations
{
    public partial class _2018_11_07_02_Actress_JP_Add_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Actress_JP",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Actress_JP");
        }
    }
}
