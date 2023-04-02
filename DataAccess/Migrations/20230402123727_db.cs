using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalTaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalTaxType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    RateToBeCharged = table.Column<int>(type: "int", nullable: false),
                    AmountToBeCollected = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalTaxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressBookId = table.Column<int>(type: "int", nullable: false),
                    BankAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxAdministrationId = table.Column<int>(type: "int", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    BusinessTransactionId = table.Column<int>(type: "int", nullable: false),
                    VatNumber = table.Column<int>(type: "int", nullable: false),
                    DiscountRate = table.Column<int>(type: "int", nullable: false),
                    CarrierId = table.Column<int>(type: "int", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxIdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessTransactionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "carrierCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressBookId = table.Column<int>(type: "int", nullable: false),
                    InstitutionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carrierCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Workplace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CashCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlugName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debt = table.Column<int>(type: "int", nullable: false),
                    Cash = table.Column<int>(type: "int", nullable: false),
                    ReceiptNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashCollections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrlugName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debt = table.Column<int>(type: "int", nullable: false),
                    Cash = table.Column<int>(type: "int", nullable: false),
                    ReceiptNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCreditCardReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    CreditCardNumber = table.Column<int>(type: "int", nullable: false),
                    BatchNumber = table.Column<int>(type: "int", nullable: false),
                    ConfirmationNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCreditCardReceipts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCreditCardReturnSlips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    CreditCardNumber = table.Column<int>(type: "int", nullable: false),
                    BatchNumber = table.Column<int>(type: "int", nullable: false),
                    ConfirmationNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCreditCardReturnSlips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreditCardReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    CreditCardNumber = table.Column<int>(type: "int", nullable: false),
                    BatchNumber = table.Column<int>(type: "int", nullable: false),
                    ConfirmationNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardReceipts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreditCardReturnSlips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    CreditCardNumber = table.Column<int>(type: "int", nullable: false),
                    BatchNumber = table.Column<int>(type: "int", nullable: false),
                    ConfirmationNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardReturnSlips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debit = table.Column<int>(type: "int", nullable: false),
                    Ready = table.Column<int>(type: "int", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    ReceiptNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentAccounts",
                columns: table => new
                {
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessInformationId = table.Column<int>(type: "int", nullable: false),
                    AddressBookId = table.Column<int>(type: "int", nullable: false),
                    Appellation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternetBusinessCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentAccounts", x => x.CurrentAccountId);
                });

            migrationBuilder.CreateTable(
                name: "Debts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debit = table.Column<int>(type: "int", nullable: false),
                    Ready = table.Column<int>(type: "int", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    ReceiptNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GivenInterestRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GivenInterestRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GivenSelfEmploymentReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WithholdingRate = table.Column<int>(type: "int", nullable: false),
                    FundShareRate = table.Column<int>(type: "int", nullable: false),
                    WithholdingId = table.Column<int>(type: "int", nullable: false),
                    TotalDeductions = table.Column<int>(type: "int", nullable: false),
                    ExactFee = table.Column<int>(type: "int", nullable: false),
                    TotalReceived = table.Column<int>(type: "int", nullable: false),
                    ServiceReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GivenSelfEmploymentReceipts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelfLife = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfUs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AdditionalTaxId = table.Column<int>(type: "int", nullable: false),
                    VatRate = table.Column<int>(type: "int", nullable: false),
                    Purchasing = table.Column<int>(type: "int", nullable: false),
                    Sale = table.Column<int>(type: "int", nullable: false),
                    Return = table.Column<int>(type: "int", nullable: false),
                    RetailSale = table.Column<int>(type: "int", nullable: false),
                    RetailReturn = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    WithholdingId = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    UnitBarcode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    CurrentAccontId = table.Column<int>(type: "int", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    BusinessTransactionId = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Finish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryCode = table.Column<int>(type: "int", nullable: false),
                    DeliveryDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSlugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    AdditionalTaxBase = table.Column<int>(type: "int", nullable: false),
                    AdditionalTaxAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSlugs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    InterestRate = table.Column<int>(type: "int", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvideOfServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    AdditionalTaxId = table.Column<int>(type: "int", nullable: false),
                    VatRate = table.Column<int>(type: "int", nullable: false),
                    VatSaleRate = table.Column<int>(type: "int", nullable: false),
                    VatReturnRate = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    WithholdingId = table.Column<int>(type: "int", nullable: false),
                    ServiceReceiveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvideOfServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PruchaseReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    SalesReceiptType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialsId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    Vat = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    VATExemptionCode = table.Column<int>(type: "int", nullable: false),
                    CPACode = table.Column<int>(type: "int", nullable: false),
                    GTIPCode = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: false),
                    ReceiptNumber = table.Column<int>(type: "int", nullable: false),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    CarrierId = table.Column<int>(type: "int", nullable: false),
                    PackageParcelNumber = table.Column<int>(type: "int", nullable: false),
                    TransportType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PruchaseReceipts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchasingMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    CurrentAccontId = table.Column<int>(type: "int", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    BusinessTransactionId = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Finish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryCode = table.Column<int>(type: "int", nullable: false),
                    DeliveryDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasingMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    RoundingBase = table.Column<int>(type: "int", nullable: false),
                    VatRate = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesCosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesDiscounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SalesDidscountType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDiscounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalTaxBase = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AdditionalTaxAmount = table.Column<int>(type: "int", nullable: false),
                    PendingAmount = table.Column<int>(type: "int", nullable: false),
                    WithholdingId = table.Column<int>(type: "int", nullable: false),
                    CPACode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GTIPCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vat = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PendingReserveAmount = table.Column<int>(type: "int", nullable: false),
                    Reserve = table.Column<bool>(type: "bit", nullable: false),
                    ReserveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReserveAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    SalesReceiptType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialsId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    Vat = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    VATExemptionCode = table.Column<int>(type: "int", nullable: false),
                    CPACode = table.Column<int>(type: "int", nullable: false),
                    GTIPCode = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: false),
                    ReceiptNumber = table.Column<int>(type: "int", nullable: false),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    CarrierId = table.Column<int>(type: "int", nullable: false),
                    PackageParcelNumber = table.Column<int>(type: "int", nullable: false),
                    TransportType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReceipts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellingExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    VatRate = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingExpenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicePurchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    CurrentAccontId = table.Column<int>(type: "int", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    BusinessTransactionId = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Finish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryCode = table.Column<int>(type: "int", nullable: false),
                    DeliveryDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePurchases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceReceives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    AdditionalTaxId = table.Column<int>(type: "int", nullable: false),
                    VatRate = table.Column<int>(type: "int", nullable: false),
                    VatSaleRate = table.Column<int>(type: "int", nullable: false),
                    VatReturnRate = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    WithholdingId = table.Column<int>(type: "int", nullable: false),
                    ProvideOfServiceId = table.Column<int>(type: "int", nullable: false),
                    DistributionType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceReceives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    UnitSetId = table.Column<int>(type: "int", nullable: false),
                    CurrentAccontId = table.Column<int>(type: "int", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    BusinessTransactionId = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Finish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryCode = table.Column<int>(type: "int", nullable: false),
                    DeliveryDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAdresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddressBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAdresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialPlugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debit = table.Column<int>(type: "int", nullable: false),
                    Ready = table.Column<int>(type: "int", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    ReceiptNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialPlugs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TakenInterestRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakenInterestRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TakenSelfEmploymentReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WithholdingRate = table.Column<int>(type: "int", nullable: false),
                    FundShareRate = table.Column<int>(type: "int", nullable: false),
                    WithholdingId = table.Column<int>(type: "int", nullable: false),
                    TotalDeductions = table.Column<int>(type: "int", nullable: false),
                    ExactFee = table.Column<int>(type: "int", nullable: false),
                    TotalReceived = table.Column<int>(type: "int", nullable: false),
                    ServiceReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakenSelfEmploymentReceipts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxAdministrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxAdministrationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxAdministrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseUnitCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseUnitCodeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Multiplier = table.Column<int>(type: "int", nullable: false),
                    Divisor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VirmanPlugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAccountId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debit = table.Column<int>(type: "int", nullable: false),
                    Ready = table.Column<int>(type: "int", nullable: false),
                    PaymentPlanId = table.Column<int>(type: "int", nullable: false),
                    ReceiptNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirmanPlugs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalTaxes");

            migrationBuilder.DropTable(
                name: "AddressBooks");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "BusinessInformations");

            migrationBuilder.DropTable(
                name: "BusinessTransactions");

            migrationBuilder.DropTable(
                name: "carrierCompanies");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "CashCollections");

            migrationBuilder.DropTable(
                name: "CashPayments");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "CompanyCreditCardReceipts");

            migrationBuilder.DropTable(
                name: "CompanyCreditCardReturnSlips");

            migrationBuilder.DropTable(
                name: "CreditCardReceipts");

            migrationBuilder.DropTable(
                name: "CreditCardReturnSlips");

            migrationBuilder.DropTable(
                name: "Credits");

            migrationBuilder.DropTable(
                name: "CurrentAccounts");

            migrationBuilder.DropTable(
                name: "Debts");

            migrationBuilder.DropTable(
                name: "GivenInterestRates");

            migrationBuilder.DropTable(
                name: "GivenSelfEmploymentReceipts");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "MaterialSales");

            migrationBuilder.DropTable(
                name: "MaterialSlugs");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "PaymentPlans");

            migrationBuilder.DropTable(
                name: "ProvideOfServices");

            migrationBuilder.DropTable(
                name: "PruchaseReceipts");

            migrationBuilder.DropTable(
                name: "PurchasingMaterials");

            migrationBuilder.DropTable(
                name: "SalesCosts");

            migrationBuilder.DropTable(
                name: "SalesDiscounts");

            migrationBuilder.DropTable(
                name: "SalesOrders");

            migrationBuilder.DropTable(
                name: "SalesReceipts");

            migrationBuilder.DropTable(
                name: "SellingExpenses");

            migrationBuilder.DropTable(
                name: "ServicePurchases");

            migrationBuilder.DropTable(
                name: "ServiceReceives");

            migrationBuilder.DropTable(
                name: "ServiceSales");

            migrationBuilder.DropTable(
                name: "ShippingAdresses");

            migrationBuilder.DropTable(
                name: "SpecialPlugs");

            migrationBuilder.DropTable(
                name: "TakenInterestRates");

            migrationBuilder.DropTable(
                name: "TakenSelfEmploymentReceipts");

            migrationBuilder.DropTable(
                name: "TaxAdministrations");

            migrationBuilder.DropTable(
                name: "UnitSets");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VirmanPlugs");
        }
    }
}
