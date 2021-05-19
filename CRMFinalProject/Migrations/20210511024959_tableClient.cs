using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativeFuneralFundInc.Migrations
{
    public partial class tableClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documents = table.Column<string>(nullable: true),
                    Branding = table.Column<string>(nullable: true),
                    ClientContacts = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientID", "Branding", "ClientContacts", "Documents" },
                values: new object[] { 1, "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
