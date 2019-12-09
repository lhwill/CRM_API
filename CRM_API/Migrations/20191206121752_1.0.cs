using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_API.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Base_Dictionary",
                columns: table => new
                {
                    did = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_type = table.Column<string>(nullable: true),
                    data_code = table.Column<string>(nullable: true),
                    data_value = table.Column<string>(nullable: true),
                    pid = table.Column<int>(nullable: false),
                    sort = table.Column<int>(nullable: false),
                    remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base_Dictionary", x => x.did);
                });

            migrationBuilder.CreateTable(
                name: "Buy_Product",
                columns: table => new
                {
                    RId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<int>(nullable: false),
                    BNO = table.Column<string>(nullable: true),
                    BTime = table.Column<DateTime>(nullable: false),
                    Product = table.Column<int>(nullable: false),
                    PNum = table.Column<int>(nullable: false),
                    TotalMoney = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buy_Product", x => x.RId);
                });

            migrationBuilder.CreateTable(
                name: "Contact_Record",
                columns: table => new
                {
                    RId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<int>(nullable: false),
                    RTime = table.Column<DateTime>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    outline = table.Column<string>(nullable: true),
                    detail = table.Column<string>(nullable: true),
                    remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_Record", x => x.RId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNO = table.Column<int>(nullable: false),
                    CName = table.Column<int>(nullable: false),
                    AID = table.Column<int>(nullable: false),
                    LId = table.Column<int>(nullable: false),
                    Credit = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Remark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CId);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Away",
                columns: table => new
                {
                    AId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CId = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Reamrk = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Away", x => x.AId);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Person",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<int>(nullable: false),
                    PName = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Telphone = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Person", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "Customer_plan",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SId = table.Column<int>(nullable: false),
                    PTime = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    Result = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_plan", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Service",
                columns: table => new
                {
                    sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_type = table.Column<int>(nullable: false),
                    CID = table.Column<int>(nullable: false),
                    EID_create = table.Column<int>(nullable: false),
                    create_time = table.Column<DateTime>(nullable: false),
                    state = table.Column<int>(nullable: false),
                    EID_appoint = table.Column<int>(nullable: false),
                    ftime = table.Column<DateTime>(nullable: false),
                    EID_do = table.Column<int>(nullable: false),
                    remark = table.Column<string>(nullable: true),
                    do_time = table.Column<DateTime>(nullable: false),
                    do_result = table.Column<string>(nullable: true),
                    pleased = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Service", x => x.sid);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentInfo",
                columns: table => new
                {
                    DId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DName = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentInfo", x => x.DId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInfo",
                columns: table => new
                {
                    EId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ENO = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EName = table.Column<string>(nullable: true),
                    IDCard = table.Column<string>(nullable: true),
                    DID = table.Column<int>(nullable: false),
                    Sex = table.Column<bool>(nullable: false),
                    Phone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfo", x => x.EId);
                });

            migrationBuilder.CreateTable(
                name: "EmpRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RID = table.Column<int>(nullable: false),
                    EID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuInfo",
                columns: table => new
                {
                    MId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MName = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    PId = table.Column<int>(nullable: false),
                    Sort = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuInfo", x => x.MId);
                });

            migrationBuilder.CreateTable(
                name: "RoleInfo",
                columns: table => new
                {
                    RId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RName = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleInfo", x => x.RId);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RId = table.Column<int>(nullable: false),
                    MId = table.Column<int>(nullable: false),
                    C = table.Column<int>(nullable: false),
                    R = table.Column<int>(nullable: false),
                    U = table.Column<int>(nullable: false),
                    D = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale_Chance",
                columns: table => new
                {
                    SId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SNO = table.Column<string>(nullable: true),
                    EID_create = table.Column<int>(nullable: false),
                    CTime = table.Column<DateTime>(nullable: false),
                    EID_appoint = table.Column<int>(nullable: false),
                    FTime = table.Column<DateTime>(nullable: false),
                    EID_do = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale_Chance", x => x.SId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Base_Dictionary");

            migrationBuilder.DropTable(
                name: "Buy_Product");

            migrationBuilder.DropTable(
                name: "Contact_Record");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Customer_Away");

            migrationBuilder.DropTable(
                name: "Customer_Person");

            migrationBuilder.DropTable(
                name: "Customer_plan");

            migrationBuilder.DropTable(
                name: "Customer_Service");

            migrationBuilder.DropTable(
                name: "DepartmentInfo");

            migrationBuilder.DropTable(
                name: "EmployeeInfo");

            migrationBuilder.DropTable(
                name: "EmpRole");

            migrationBuilder.DropTable(
                name: "MenuInfo");

            migrationBuilder.DropTable(
                name: "RoleInfo");

            migrationBuilder.DropTable(
                name: "RoleMenu");

            migrationBuilder.DropTable(
                name: "Sale_Chance");
        }
    }
}
