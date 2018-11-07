using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PARKJS.WORK.STUDY04.Data.Migrations
{
    public partial class _2018_11_07_01_Actress_JP_Reg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actress_JP",
                columns: table => new
                {
                    Actr_JP_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ProfessionalName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Nationality = table.Column<string>(nullable: true),
                    Rate = table.Column<decimal>(nullable: false),
                    Ranking = table.Column<int>(nullable: false),
                    ActivityTime_From = table.Column<string>(nullable: true),
                    ActivityTime_To = table.Column<string>(nullable: true),
                    RegistDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actress_JP", x => x.Actr_JP_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actress_JP");
        }
    }
}
