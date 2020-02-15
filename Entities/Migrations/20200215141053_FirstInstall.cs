using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class FirstInstall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activated = table.Column<bool>(nullable: false),
                    AllDeposit = table.Column<decimal>(nullable: false),
                    AllPay = table.Column<decimal>(nullable: false),
                    BankBranch = table.Column<string>(nullable: true),
                    BankMark = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    BankNumber = table.Column<string>(nullable: true),
                    BankType = table.Column<bool>(nullable: false),
                    OverMoney = table.Column<decimal>(nullable: false),
                    RealName = table.Column<string>(nullable: true),
                    State = table.Column<bool>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainName = table.Column<string>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Port = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    State = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account = table.Column<string>(nullable: true),
                    AppId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsRedirect = table.Column<bool>(nullable: false),
                    Mark = table.Column<string>(nullable: true),
                    MaxAmount = table.Column<decimal>(nullable: false),
                    Md5Key = table.Column<string>(nullable: true),
                    MinAmount = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PrivateKey = table.Column<string>(nullable: true),
                    PublicKey = table.Column<string>(nullable: true),
                    RiskDomain = table.Column<string>(nullable: true),
                    RiskState = table.Column<bool>(nullable: false),
                    State = table.Column<bool>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GalleryRates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<decimal>(nullable: false),
                    RequestUrl = table.Column<string>(nullable: true),
                    Route = table.Column<bool>(nullable: false),
                    GalleryId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Uuid = table.Column<string>(nullable: true),
                    MerchantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(nullable: false),
                    LoginTime = table.Column<DateTime>(nullable: false),
                    Ip = table.Column<string>(nullable: true),
                    MerchantId = table.Column<int>(nullable: false),
                    SelfCount = table.Column<int>(nullable: false),
                    VTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Ip = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MerchantLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Ip = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    MerchantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MerchantProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<bool>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account = table.Column<string>(nullable: true),
                    Fee = table.Column<decimal>(nullable: false),
                    FinalDate = table.Column<DateTime>(nullable: false),
                    IsIps = table.Column<bool>(nullable: false),
                    IsLogger = table.Column<bool>(nullable: false),
                    JoinDate = table.Column<DateTime>(nullable: false),
                    LeaveState = table.Column<bool>(nullable: false),
                    Nickname = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneState = table.Column<bool>(nullable: false),
                    QqNumber = table.Column<string>(nullable: true),
                    SecretKey = table.Column<string>(nullable: true),
                    ServicePhone = table.Column<string>(nullable: true),
                    ServiceQq = table.Column<string>(nullable: true),
                    ServiceState = table.Column<bool>(nullable: false),
                    SettlementType = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Type = table.Column<bool>(nullable: false),
                    Uuid = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    RankId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    LeaveDate = table.Column<DateTime>(nullable: false),
                    PartitionName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Qq = table.Column<string>(nullable: true),
                    State = table.Column<bool>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Publisher = table.Column<string>(nullable: true),
                    State = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentProfit = table.Column<decimal>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CardNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GiveAmount = table.Column<decimal>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    MerchantProfit = table.Column<decimal>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderNumber = table.Column<string>(nullable: true),
                    PlatformProfit = table.Column<decimal>(nullable: false),
                    PlayerPhone = table.Column<string>(nullable: true),
                    PlayerQq = table.Column<string>(nullable: true),
                    RedPacketAmount = table.Column<decimal>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    SupNumber = table.Column<string>(nullable: true),
                    TailAmount = table.Column<decimal>(nullable: false),
                    TailAmountProfit = table.Column<decimal>(nullable: false),
                    TailRate = table.Column<decimal>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    AgentId = table.Column<int>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false),
                    PartitionId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    GalleryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartitionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    PartitionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartitionGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partitions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DataFormat = table.Column<string>(nullable: true),
                    DbInfo = table.Column<string>(nullable: true),
                    IsChangeInTime = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notice = table.Column<string>(nullable: true),
                    NoticeState = table.Column<bool>(nullable: false),
                    ScriptPath = table.Column<string>(nullable: true),
                    ServerIp = table.Column<string>(nullable: true),
                    ServerPort = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    State = table.Column<bool>(nullable: false),
                    SuccessMark = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    UseDate = table.Column<DateTime>(nullable: false),
                    UseName = table.Column<string>(nullable: true),
                    Uuid = table.Column<string>(nullable: true),
                    WebUrl = table.Column<string>(nullable: true),
                    YbEgg = table.Column<bool>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false),
                    TemplateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayForAnothers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(nullable: true),
                    AppSecret = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mark = table.Column<string>(nullable: true),
                    MarkName = table.Column<string>(nullable: true),
                    Partner = table.Column<string>(nullable: true),
                    PublicKey = table.Column<string>(nullable: true),
                    RedirectUrl = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    ReqUrl = table.Column<string>(nullable: true),
                    SecurityKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayForAnothers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Type = table.Column<bool>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<string>(nullable: true),
                    MarkName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    State = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    TypeMark = table.Column<string>(nullable: true),
                    GalleryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RankRates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<decimal>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    RankId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsAgency = table.Column<bool>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MerchantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReissueRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(nullable: false),
                    PlayerName = table.Column<string>(nullable: true),
                    PlayerAccount = table.Column<string>(nullable: true),
                    ReissueDate = table.Column<DateTime>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    Type = table.Column<bool>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false),
                    PartitionId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReissueRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchedulerJobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CronExpression = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GroupName = table.Column<string>(nullable: true),
                    JsonData = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchedulerJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SettlementReplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    ReplyDate = table.Column<DateTime>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    State = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettlementReplies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settlements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(nullable: false),
                    ApplyDate = table.Column<DateTime>(nullable: false),
                    CompleteDate = table.Column<DateTime>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    BankId = table.Column<int>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false),
                    SettlementReplyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settlements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemSets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    Cq3Version = table.Column<string>(nullable: true),
                    DefaultFee = table.Column<decimal>(nullable: false),
                    FeeStandard = table.Column<string>(nullable: true),
                    GameEngine = table.Column<string>(nullable: true),
                    IsIps = table.Column<bool>(nullable: false),
                    IsLogin = table.Column<bool>(nullable: false),
                    IsOpenTailAmount = table.Column<bool>(nullable: false),
                    LoginTime = table.Column<int>(nullable: false),
                    Mark = table.Column<string>(nullable: true),
                    RegisterState = table.Column<int>(nullable: false),
                    ServicePhone = table.Column<string>(nullable: true),
                    ServiceQq = table.Column<string>(nullable: true),
                    SettlementBank = table.Column<string>(nullable: true),
                    SettlementType = table.Column<int>(nullable: false),
                    T0MinAmount = table.Column<decimal>(nullable: false),
                    T1MinAmount = table.Column<decimal>(nullable: false),
                    TailAmountRatio = table.Column<int>(nullable: false),
                    TailAmountScope = table.Column<int>(nullable: false),
                    TaskCount = table.Column<int>(nullable: false),
                    TimedSettlement = table.Column<bool>(nullable: false),
                    TyVersion = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    VisitTime = table.Column<int>(nullable: false),
                    WebName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountRate = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    TemplateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrowserCommand = table.Column<string>(nullable: true),
                    CardState = table.Column<bool>(nullable: false),
                    CurrencyName = table.Column<string>(nullable: true),
                    EquipType = table.Column<int>(nullable: false),
                    GameEngine = table.Column<string>(nullable: true),
                    GiveState = table.Column<bool>(nullable: false),
                    GiveWay = table.Column<bool>(nullable: false),
                    InfoAdditional = table.Column<string>(nullable: true),
                    InfoEquip = table.Column<string>(nullable: true),
                    InfoIncentive = table.Column<string>(nullable: true),
                    InfoIntegral = table.Column<string>(nullable: true),
                    InfoNpc = table.Column<string>(nullable: true),
                    InfoRedPacket = table.Column<string>(nullable: true),
                    IsContains = table.Column<bool>(nullable: false),
                    MaxAmount = table.Column<decimal>(nullable: false),
                    MinAmount = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Ratio = table.Column<int>(nullable: false),
                    RechargeWay = table.Column<string>(nullable: true),
                    RedPacketAdditional = table.Column<bool>(nullable: false),
                    RedPacketEquip = table.Column<bool>(nullable: false),
                    RedPacketIntegral = table.Column<bool>(nullable: false),
                    RedPacketState = table.Column<bool>(nullable: false),
                    ScriptCommand = table.Column<string>(nullable: true),
                    ShowAdditional = table.Column<bool>(nullable: false),
                    ShowEquip = table.Column<bool>(nullable: false),
                    ShowIntegral = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<string>(nullable: true),
                    TokenId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(nullable: false),
                    LoginTime = table.Column<DateTime>(nullable: false),
                    Domain = table.Column<string>(nullable: true),
                    Ips = table.Column<string>(nullable: true),
                    MerchantId = table.Column<int>(nullable: false),
                    OrderCount = table.Column<int>(nullable: false),
                    OrderMoney = table.Column<decimal>(nullable: false),
                    Profit = table.Column<decimal>(nullable: false),
                    VisitDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeixinInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessToken = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    ExpiresIn = table.Column<int>(nullable: false),
                    HeadImgUrl = table.Column<string>(nullable: true),
                    JoinDate = table.Column<DateTime>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false),
                    Nickname = table.Column<string>(nullable: true),
                    OpenId = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    RefreshToken = table.Column<string>(nullable: true),
                    sex = table.Column<bool>(nullable: false),
                    UnionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeixinInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Circuits");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "GalleryRates");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "LoginRecords");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "MerchantLogs");

            migrationBuilder.DropTable(
                name: "MerchantProducts");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PartitionGroups");

            migrationBuilder.DropTable(
                name: "Partitions");

            migrationBuilder.DropTable(
                name: "PayForAnothers");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RankRates");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "ReissueRecords");

            migrationBuilder.DropTable(
                name: "SchedulerJobs");

            migrationBuilder.DropTable(
                name: "SettlementReplies");

            migrationBuilder.DropTable(
                name: "Settlements");

            migrationBuilder.DropTable(
                name: "SystemSets");

            migrationBuilder.DropTable(
                name: "TemplateProducts");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "WeixinInfos");
        }
    }
}
