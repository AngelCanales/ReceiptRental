using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReceiptRental.Services;
using ReceiptRental.Views;
using Prism.DryIoc;
using System.Globalization;
using Prism;
using Prism.Ioc;
using ReceiptRental.ViewModels;
using System.Threading;
using ReceiptRental.Resource;
using ReceiptRental.Database;
using ReceiptRental.PVCBCore.Invoices;
using ReceiptRental.Database.Repositories;
using Prism.Navigation;
using ReceiptRental.Models;
using ReceiptRental.PVCBCore.Products;
using ReceiptRental.PVCBCore.Parameters;
using ReceiptRental.PVCBCore.Inventories;
using Microsoft.EntityFrameworkCore;
using ReceiptRental.PVCBCore.Providers;
using ReceiptRental.PVCBCore.Customers;

namespace ReceiptRental
{
    public partial class App : PrismApplication
    {

        public App()
          : this(null)
        {
        }

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }


        protected override async void OnInitialized()
        {
            this.InitializeComponent();


            var culture = CultureInfo.InstalledUICulture;

            var myCurrency = new CultureInfo("es-HN");
            CultureInfo.DefaultThreadCurrentCulture = myCurrency;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(myCurrency.IetfLanguageTag);
            ResourceGlobal.Culture = new CultureInfo(myCurrency.IetfLanguageTag);

           
           
                try
                {
                if (!DesignMode.IsDesignModeEnabled)
                {
                    var context = new PVCBContext();
                    await ReceiptRental.ReceiptRentalSeedData.ReceiptRentalSeedData.EnsureReceiptRentalSeedData(context);
                }
            }
                catch (Exception )
                {
                }
           

         

            var param = new NavigationParameters();
            param.Add("NameFile", "dataCashBack.json");
            await this.NavigationService.NavigateAsync("MasterDetailPage/NavigationPage/SummaryPage", param);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<Views.MasterDetailPage, MasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<SalesPage, SalesViewModel>();
            containerRegistry.RegisterForNavigation<SummaryPage, SummaryPageViewModel>();
            containerRegistry.RegisterForNavigation<LottiePage, LottiePageViewModel>();
            containerRegistry.RegisterForNavigation<TransactionsPage, TransactionsPageViewModel>();
            containerRegistry.RegisterForNavigation<TransactionDetailsPage, TransactionDetailsPageViewModel>();
            containerRegistry.RegisterForNavigation<MonthlyReportPage, MonthlyReportViewModel>();
            containerRegistry.RegisterForNavigation<AnnualReportPage, AnnualReportPageViewModel>();
            containerRegistry.RegisterForNavigation<ListProductsPage,ListProductsPageViewModel>();
            containerRegistry.RegisterForNavigation<AddProductPage, AddProductPageViewModel>();
            containerRegistry.RegisterForNavigation<ListProductsDetailPage, ListProductsDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<SearchProductPage, SearchProductPageViewModel>();
            containerRegistry.RegisterForNavigation<InvoiceTabbedPage, InvoiceTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<InvoiceDetailPage, InvoiceDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ReceiptPage, ReceiptPageViewModel>();
            containerRegistry.RegisterForNavigation<InventoriesPage, InventoriesPageViewModel>();
            containerRegistry.RegisterForNavigation<ListParametersPage, ListParametersPageViewModel>();
            containerRegistry.RegisterForNavigation<ParametersDetailPage, ParametersDetailPageViewModel>();

            containerRegistry.RegisterForNavigation<ListProvidersPage, ListProvidersPageViewModel>();
            containerRegistry.RegisterForNavigation<ListProvidersDetailPage, ListProvidersDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AddProviderPage, AddProviderPageViewModel>();
            containerRegistry.RegisterForNavigation<SearchProviderPage, SearchProviderPageViewModel>();

            containerRegistry.RegisterForNavigation<ListCustomersPage, ListCustomersPageViewModel>();
            containerRegistry.RegisterForNavigation<ListCustomersDetailPage, ListCustomersDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AddCustomersPage, AddCustomersPageViewModel>();
            containerRegistry.RegisterForNavigation<SearchCustomerPage, SearchCustomerPageViewModel>();

            // Data access
            containerRegistry.RegisterSingleton<IRepository<Database.Models.Invoices>, InvoicesRepository>();
            containerRegistry.RegisterSingleton<IRepository<Database.Models.DetailInvoices>, DetailInvoicesRepository>();
            containerRegistry.RegisterSingleton<IRepository<Database.Models.Products>, ProductRepository>();
            containerRegistry.RegisterSingleton<IRepository<Database.Models.Parameters>, ParametersRepository>();

            containerRegistry.RegisterSingleton<IRepository<Database.Models.Providers>, ProvidersRepository>();
            containerRegistry.RegisterSingleton<IRepository<Database.Models.Customers>, CustomersRepository>();
            containerRegistry.RegisterSingleton<IRepository<Database.Models.PaymentTypes>, PaymentTypesRepository>();
            containerRegistry.RegisterSingleton<IRepository<Database.Models.SalesTypes>, SalesTypesRepository>();
            containerRegistry.RegisterSingleton<IRepository<Database.Models.Routes>, RoutesRepository>();
            containerRegistry.RegisterSingleton<IRepository<Database.Models.Employees>, EmployeesRepository>(); 
            containerRegistry.RegisterSingleton<IRepository<Database.Models.Inventories>, InventoriesRepository>();

            containerRegistry.RegisterSingleton<IInvoicesManager, InvoicesManager>();
            containerRegistry.RegisterSingleton<IProductsManager, ProductsManager>();
            containerRegistry.RegisterSingleton<IParametersManager, ParametersManager>();
            containerRegistry.RegisterSingleton<IInventoriesManager, InventoriesManager>();

            containerRegistry.RegisterSingleton<IProvidersManager, ProvidersManager>();
            containerRegistry.RegisterSingleton<ICustomersManager, CustomersManager>();


            containerRegistry.RegisterSingleton<PrintInvoice.PrintInvoice>();
            containerRegistry.RegisterSingleton<PVCBContext>();
            containerRegistry.RegisterSingleton<ReceiptRental.ReceiptRentalSeedData.ReceiptRentalSeedData>();
            


        }
    }
}