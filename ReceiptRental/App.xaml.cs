// <copyright file="App.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReceiptRental
{
    using System;
    using System.Globalization;
    using System.Threading;
    using Prism;
    using Prism.DryIoc;
    using Prism.Ioc;
    using Prism.Navigation;
    using ReceiptRental.Database;
    using ReceiptRental.Database.Models;
    using ReceiptRental.Database.Repositories;
    using ReceiptRental.ReceiptRentalCore.Alkylinos;
    using ReceiptRental.Resource;
    using ReceiptRental.ViewModels;
    using ReceiptRental.Views;
    using Xamarin.Forms;

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
                    var context = new ReceiptRentalContext();
                    await ReceiptRental.ReceiptRentalSeedData.ReceiptRentalSeedData.EnsureReceiptRentalSeedData(context);
                }
            }
            catch (Exception)
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
            containerRegistry.RegisterForNavigation<ListProductsPage, ListProductsPageViewModel>();
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
            containerRegistry.RegisterSingleton<IRepository<PaymentTypes>, DbContextRepositoryBase<PaymentTypes>>();

            containerRegistry.RegisterSingleton<IAlkylinoManager, AlkylinoManager>();

            containerRegistry.RegisterSingleton<PrintInvoice.PrintInvoice>();
            containerRegistry.RegisterSingleton<ReceiptRentalContext>();
            containerRegistry.RegisterSingleton<ReceiptRental.ReceiptRentalSeedData.ReceiptRentalSeedData>();



        }
    }
}