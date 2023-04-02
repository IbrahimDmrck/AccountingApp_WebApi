using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class AccountingContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4VOSQ2D;Database=AccountingApp;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        public DbSet<AdditionalTax> AdditionalTaxes { get; set; }
        public DbSet<AddressBook> AddressBooks { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BusinessInformation> BusinessInformations { get; set; }
        public DbSet<BusinessTransaction> BusinessTransactions { get; set; }
        public DbSet<CarrierCompany> carrierCompanies { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<CashCollection> CashCollections { get; set; }
        public DbSet<CashPayment> CashPayments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyCreditCardReceipt> CompanyCreditCardReceipts { get; set; }
        public DbSet<CompanyCreditCardReturnSlip> CompanyCreditCardReturnSlips { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<CreditCardReceipt> CreditCardReceipts { get; set; }
        public DbSet<CreditCardReturnSlip> CreditCardReturnSlips { get; set; }
        public DbSet<CurrentAccount> CurrentAccounts { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<GivenInterestRate> GivenInterestRates { get; set; }
        public DbSet<GivenSelfEmploymentReceipt> GivenSelfEmploymentReceipts { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<MaterialSales> MaterialSales { get; set; }
        public DbSet<MaterialSlug> MaterialSlugs { get; set; }
        public DbSet<PaymentPlan> PaymentPlans { get; set; }
        public DbSet<ProvideOfService> ProvideOfServices { get; set; }
        public DbSet<PruchaseReceipt> PruchaseReceipts { get; set; }
        public DbSet<PurchasingMaterial> PurchasingMaterials { get; set; }
        public DbSet<SalesCost> SalesCosts { get; set; }
        public DbSet<SalesDiscount> SalesDiscounts { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesReceipt> SalesReceipts { get; set; }
        public DbSet<SellingExpense> SellingExpenses { get; set; }
        public DbSet<ServicePurchase> ServicePurchases { get; set; }
        public DbSet<ServiceReceive> ServiceReceives { get; set; }
        public DbSet<ServiceSales> ServiceSales { get; set; }
        public DbSet<ShippingAdress> ShippingAdresses { get; set; }
        public DbSet<SpecialPlug> SpecialPlugs { get; set; }
        public DbSet<TakenInterestRate> TakenInterestRates { get; set; }
        public DbSet<TakenSelfEmploymentReceipt> TakenSelfEmploymentReceipts { get; set; }
        public DbSet<TaxAdministration> TaxAdministrations { get; set; }
        public DbSet<UnitSet> UnitSets { get; set; }
        public DbSet<VirmanPlug> VirmanPlugs { get; set; }
        public virtual DbSet<OperationClaim> OperationClaims { get; set; }
        public virtual DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
