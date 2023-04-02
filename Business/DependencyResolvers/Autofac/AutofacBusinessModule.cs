using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AdditionalTaxManager>().As<IAdditionalTaxService>().SingleInstance();
            builder.RegisterType<EfAdditionalTaxDal>().As<IAdditionalTaxDal>().SingleInstance();

            builder.RegisterType<AddressBookManager>().As<IAddressBookService>().SingleInstance();
            builder.RegisterType<EfAddressBookDal>().As<IAddressBookDal>().SingleInstance();

            builder.RegisterType<BankManager>().As<IBankService>().SingleInstance();
            builder.RegisterType<EfBankDal>().As<IBankDal>().SingleInstance();

            builder.RegisterType<BusinessInformationManager>().As<IBusinessInformationService>().SingleInstance();
            builder.RegisterType<EfBusinessInformationDal>().As<IBusinessInformationDal>().SingleInstance();

            builder.RegisterType<BusinessTransactionManager>().As<IBusinessTransactionService>().SingleInstance();
            builder.RegisterType<EfBusinessTransactionDal>().As<IBusinessTransactionDal>().SingleInstance();

            builder.RegisterType<CarrierCompanyManager>().As<ICarrierCompanyService>().SingleInstance();
            builder.RegisterType<EfCarrierCompanyDal>().As<ICarrierCompanyDal>().SingleInstance();

            builder.RegisterType<CaseManager>().As<ICaseService>().SingleInstance();
            builder.RegisterType<EfCaseDal>().As<ICaseDal>().SingleInstance();

            builder.RegisterType<CashCollectionManager>().As<ICashCollectionService>().SingleInstance();
            builder.RegisterType<EfCashCollectionDal>().As<ICashCollectionDal>().SingleInstance();

            builder.RegisterType<CashPaymentManager>().As<ICashPaymentService>().SingleInstance();
            builder.RegisterType<EfCashPaymentDal>().As<ICashPaymentDal>().SingleInstance();

            builder.RegisterType<CompanyCreditCardReceiptManager>().As<ICompanyCreditCardReceiptService>().SingleInstance();
            builder.RegisterType<EfCompanyCreditCardReceiptDal>().As<ICompanyCreditCardReceiptDal>().SingleInstance();

            builder.RegisterType<CompanyCreditCardReturnSlipManager>().As<ICompanyCreditCardReturnSlipService>().SingleInstance();
            builder.RegisterType<EfCompanyCreditCardReturnSlipDal>().As<ICompanyCreditCardReturnSlipDal>().SingleInstance();

            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

            builder.RegisterType<CreditCardReceiptManager>().As<ICreditCardReceiptService>().SingleInstance();
            builder.RegisterType<EfCreditCardReceiptDal>().As<ICreditCardReceiptDal>().SingleInstance();

            builder.RegisterType<CreditCardReturnSlipManager>().As<ICreditCardReturnSlipService>().SingleInstance();
            builder.RegisterType<EfCreditCardReturnSlipDal>().As<ICreditCardReturnSlipDal>().SingleInstance();

            builder.RegisterType<CreditManager>().As<ICreditService>().SingleInstance();
            builder.RegisterType<EfCreditDal>().As<ICreditDal>().SingleInstance();

            builder.RegisterType<CurrentAccountManager>().As<ICurrentAccountService>().SingleInstance();
            builder.RegisterType<EfCurrentAccountDal>().As<ICurrentAccountDal>().SingleInstance();

            builder.RegisterType<DebtManager>().As<IDebtService>().SingleInstance();
            builder.RegisterType<EfDebtDal>().As<IDebtDal>().SingleInstance();

            builder.RegisterType<GivenInterestRateManager>().As<IGivenInterestRateService>().SingleInstance();
            builder.RegisterType<EfGivenInterestRateDal>().As<IGivenInterestRateDal>().SingleInstance();

            builder.RegisterType<GivenSelfEmploymentReceiptManager>().As<IGivenSelfEmploymentReceiptService>().SingleInstance();
            builder.RegisterType<EfGivenSelfEmploymentReceiptDal>().As<IGivenSelfEmploymentReceiptDal>().SingleInstance();

            builder.RegisterType<MaterialManager>().As<IMaterialService>().SingleInstance();
            builder.RegisterType<EfMaterialsDal>().As<IMaterialsDal>().SingleInstance();

            builder.RegisterType<MaterialSalesManager>().As<IMaterialSalesService>().SingleInstance();
            builder.RegisterType<EfMaterialSalesDal>().As<IMaterialSalesDal>().SingleInstance();

            builder.RegisterType<MaterialSlugManager>().As<IMaterialSlugService>().SingleInstance();
            builder.RegisterType<EfMaterialSlugDal>().As<IMaterialSlugDal>().SingleInstance();

            builder.RegisterType<PaymentPlanManager>().As<IPaymentPlanService>().SingleInstance();
            builder.RegisterType<EfPaymentPlanDal>().As<IPaymentPlanDal>().SingleInstance();

            builder.RegisterType<ProvideOfServiceManager>().As<IProvideOfServiceService>().SingleInstance();
            builder.RegisterType<EfProvideOfServiceDal>().As<IProvideOfServiceDal>().SingleInstance();

            builder.RegisterType<PruchaseReceiptManager>().As<IPruchaseReceiptService>().SingleInstance();
            builder.RegisterType<EfPruchaseReceiptDal>().As<IPruchaseReceiptDal>().SingleInstance();

            builder.RegisterType<PurchasingMaterialManager>().As<IPurchasingMaterialService>().SingleInstance();
            builder.RegisterType<EfPurchasingMaterialDal>().As<IPurchasingMaterialDal>().SingleInstance();

            builder.RegisterType<SalesCostManager>().As<ISalesCostService>().SingleInstance();
            builder.RegisterType<EfSalesCostDal>().As<ISalesCostDal>().SingleInstance();

            builder.RegisterType<SalesDiscountManager>().As<ISalesDiscountService>().SingleInstance();
            builder.RegisterType<EfSalesDiscountDal>().As<ISalesDiscountDal>().SingleInstance();

            builder.RegisterType<SalesOrderManager>().As<ISalesOrderService>().SingleInstance();
            builder.RegisterType<EfSalesOrderDal>().As<ISalesOrderDal>().SingleInstance();

            builder.RegisterType<SalesReceiptManager>().As<ISalesReceiptService>().SingleInstance();
            builder.RegisterType<EfSalesReceiptDal>().As<ISalesReceiptDal>().SingleInstance();

            builder.RegisterType<SellingExpenseManager>().As<ISellingExpenseService>().SingleInstance();
            builder.RegisterType<EfSellingExpenseDal>().As<ISellingExpenseDal>().SingleInstance();

            builder.RegisterType<ServicePurchaseManager>().As<IServicePurchaseService>().SingleInstance();
            builder.RegisterType<EfServicePurchaseDal>().As<IServicePurchaseDal>().SingleInstance();

            builder.RegisterType<ServiceReceiveManager>().As<IServiceReceiveService>().SingleInstance();
            builder.RegisterType<EfServiceReceiveDal>().As<IServiceReceiveDal>().SingleInstance();

            builder.RegisterType<ServiceSalesManager>().As<IServiceSalesService>().SingleInstance();
            builder.RegisterType<EfServiceSalesDal>().As<IServiceSalesDal>().SingleInstance();

            builder.RegisterType<ShippingAdressManager>().As<IShippingAdressService>().SingleInstance();
            builder.RegisterType<EfShippingAdressDal>().As<IShippingAdressDal>().SingleInstance();

            builder.RegisterType<SpecialPlugManager>().As<ISpecialPlugService>().SingleInstance();
            builder.RegisterType<EfSpecialPlugDal>().As<ISpecialPlugDal>().SingleInstance();

            builder.RegisterType<TakenInterestRateManager>().As<ITakenInterestRateService>().SingleInstance();
            builder.RegisterType<EfTakenInterestRateDal>().As<ITakenInterestRateDal>().SingleInstance();

            builder.RegisterType<TakenSelfEmploymentReceiptManager>().As<ITakenSelfEmploymentReceiptService>().SingleInstance();
            builder.RegisterType<EfTakenSelfEmploymentReceiptDal>().As<ITakenSelfEmploymentReceiptDal>().SingleInstance();

            builder.RegisterType<TaxAdministrationManager>().As<ITaxAdministrationService>().SingleInstance();
            builder.RegisterType<EfTaxAdministrationDal>().As<ITaxAdministrationDal>().SingleInstance();

            builder.RegisterType<UnitSetManager>().As<IUnitSetService>().SingleInstance();
            builder.RegisterType<EfUnitSetDal>().As<IUnitSetDal>().SingleInstance();

            builder.RegisterType<VirmanPlugManager>().As<IVirmanPlugService>().SingleInstance();
            builder.RegisterType<EfVirmanPlugDal>().As<IVirmanPlugDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
