using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpDeskCRM.Migrations
{
    public partial class Add_TicketTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "TicketType",
                columns: table => new
                {
                    TypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketType", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketDate = table.Column<DateTime>(nullable: true),
                    TypeID = table.Column<int>(nullable: false),
                    TicketTypeTypeID = table.Column<int>(nullable: true),
                    StatusID = table.Column<int>(nullable: false),
                    TicketStatusStatusID = table.Column<int>(nullable: true),
                    PriorityID = table.Column<int>(nullable: false),
                    ContactID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    SystemID = table.Column<int>(nullable: false),
                    ScreenID = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    AssignTo = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    InsertById = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    TesterNotes = table.Column<string>(nullable: true),
                    TestCase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketStatus_TicketStatusStatusID",
                        column: x => x.TicketStatusStatusID,
                        principalTable: "TicketStatus",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketType_TicketTypeTypeID",
                        column: x => x.TicketTypeTypeID,
                        principalTable: "TicketType",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketStatusStatusID",
                table: "Tickets",
                column: "TicketStatusStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketTypeTypeID",
                table: "Tickets",
                column: "TicketTypeTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "TicketStatus");

            migrationBuilder.DropTable(
                name: "TicketType");
        }
    }
}
