using Prism;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Navigation;
using Prism.Plugin.Popups;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMVVMPrismDemo.Navigate;
using XamarinMVVMPrismDemo.View;
using XamarinMVVMPrismDemo.View.DeviceService;
using XamarinMVVMPrismDemo.View.DialogueView;
using XamarinMVVMPrismDemo.View.EventAggregator;
using XamarinMVVMPrismDemo.View.EventToCommandBehavior;
using XamarinMVVMPrismDemo.View.NavigationMode;
using XamarinMVVMPrismDemo.View.PageLifecycleAware;
using XamarinMVVMPrismDemo.View.Popup;
using XamarinMVVMPrismDemo.View.ViewModelInitialization;
using XamarinMVVMPrismDemo.View.XamlNavigation;
using XamarinMVVMPrismDemo.ViewModels;
using XamarinMVVMPrismDemo.ViewModels.DeviceServiceVM;
using XamarinMVVMPrismDemo.ViewModels.Dialogue;
using XamarinMVVMPrismDemo.ViewModels.EventAgr;
using XamarinMVVMPrismDemo.ViewModels.EventToCommandBehaviorVM;
using XamarinMVVMPrismDemo.ViewModels.MasterDetails;
using XamarinMVVMPrismDemo.ViewModels.NavigationModeVM;
using XamarinMVVMPrismDemo.ViewModels.PageLifecycleAwareVM;
using XamarinMVVMPrismDemo.ViewModels.PopupVM;
using XamarinMVVMPrismDemo.ViewModels.ViewModelInitialization;
using XamarinMVVMPrismDemo.ViewModels.XAMLNavigation;

namespace XamarinMVVMPrismDemo
{
    public partial class App : PrismApplication
    {
        //public App()
        //{
        //    InitializeComponent();

        //    MainPage = new MainPage();
        //}

        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            //NavigationService.NavigateAsync("NavigationPage/HomePage");
            NavigationService.NavigateAsync("MasterDetailsPage/NavigationPage/HomePage");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainTabPage>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<AboutUsPage, AboutUsViewModel>();
            containerRegistry.RegisterForNavigation<ContactPage, ContactViewModel>();

            //EventAggeregator
            containerRegistry.RegisterForNavigation<EventAggeregatorMainPage, EventAggeregatorMainPageViewModel>();
            containerRegistry.RegisterForNavigation<Page1, Page1ViewModel>();
            containerRegistry.RegisterForNavigation<Page2, Page2ViewModel>();

            // MasterDetails
            containerRegistry.RegisterForNavigation<MyTabbedPage>(nameof(TabbedPage));
            containerRegistry.RegisterForNavigation<View.Master.MasterDetailsPage, MasterDetailPageViewModel>();

            // Dialog Service
            containerRegistry.RegisterDialog<NameDialog,NameDialogViewModel>();

            // ViewModelInitialization
            containerRegistry.RegisterForNavigation<VMIntializationMainPage, ViewModelInitializationViewModel>();
            containerRegistry.RegisterForNavigation<PageA, PageAViewModel>();

            // PageLifecycleAware
            containerRegistry.RegisterForNavigation<PageLifecycleAwareMainPage, PageLifecycleAwareViewModel>();
            containerRegistry.RegisterForNavigation<PageLifecycle1, PageLifecycle1ViewModel>();

            // XamlNavigation
            containerRegistry.RegisterForNavigation<XAMLMainPage, XAMLMainPageViewModel>();
            containerRegistry.RegisterForNavigation<InformationPage, InformationPageViewModel>();

            // DeviceService
            containerRegistry.RegisterForNavigation<DeviceServiceMainPage, DeviceServiceMainPageViewModel>();

            // NavigationMode
            containerRegistry.RegisterForNavigation<NavigationModeMainPage, NavigationModeViewModel>();
            containerRegistry.RegisterForNavigation<SecondPage, SecondPageViewModel>();
            containerRegistry.RegisterForNavigation<ThirdPage, ThirdPageViewModel>();

            // EventToCommand
            containerRegistry.Register<IDataProvider, MockDataProvider>();
            containerRegistry.RegisterForNavigation<EventToCommandMainPage, EventToCommandViewModel>();
            containerRegistry.RegisterForNavigation<SimpleExamplePage, SimpleExamplePageViewModel>();
            containerRegistry.RegisterForNavigation<EventArgsConverterExamplePage, EventArgsConverterViewModel>();
            containerRegistry.RegisterForNavigation<EventArgsParameterExamplePage, EventArgsParameterViewModel>();

            // Popup
            containerRegistry.RegisterPopupNavigationService();
            containerRegistry.RegisterPopupDialogService();
            containerRegistry.RegisterForNavigation<PopupMainPage, PopupMainPageViewModel>();
            containerRegistry.RegisterForNavigation<SamplePopup, SamplePopupViewModel>();
            containerRegistry.RegisterDialog<SampleAlert, SampleAlertViewModel>();
            //containerRegistry.RegisterForNavigation<TabA, TabViewModel>();
            //containerRegistry.RegisterForNavigation<TabB, TabViewModel>();
            //containerRegistry.RegisterForNavigation<TabC, TabViewModel>();

            //containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }
       
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
