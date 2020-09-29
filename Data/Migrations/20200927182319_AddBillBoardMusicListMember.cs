using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class AddBillBoardMusicListMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       

            migrationBuilder.CreateTable(
                name: "BillBoardMusicListMembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Artist = table.Column<string>(nullable: true),
                    song = table.Column<string>(nullable: true),
                    duration = table.Column<string>(nullable: true),
                    Genre = table.Column<int>(nullable: false),
                    IsActiveMember = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillBoardMusicListMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillBoardMusicListMembers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillBoardMusicListMembers_UserId",
                table: "BillBoardMusicListMembers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillBoardMusicListMembers");
        }
    }
}
