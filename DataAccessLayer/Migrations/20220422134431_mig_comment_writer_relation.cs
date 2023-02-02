using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_comment_writer_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WriterID",
                table: "Comments",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Writers_WriterID",
                table: "Comments",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Writers_WriterID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_WriterID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Comments");
        }
    }
}
