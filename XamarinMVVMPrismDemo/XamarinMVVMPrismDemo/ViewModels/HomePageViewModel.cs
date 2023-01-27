using GalaSoft.MvvmLight.Views;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;
using Prism.Xaml;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMVVMPrismDemo.ViewModels
{
    public class HomePageViewModel : BaseViewModel /*, IConfirmNavigationAsync*/
    {
        public DelegateCommand NavigateCommand => new DelegateCommand(Navigate);
        public DelegateCommand NavigateVMInitialization => new DelegateCommand(NavigateToVMInitialization);
        private Prism.Services.Dialogs.IDialogService _dialogService;

        //public DelegateCommand<string> NavigateToCntCommand => new DelegateCommand<string>(NavigateToCnt);
       // IPageDialogService _pageDialogService;

        public async void Navigate()
        {
            var parameter = new NavigationParameters();
            parameter.Add("Id", Title);
            await NavigationService.NavigateAsync("AboutUsPage", parameter);

            //await NavigationService.NavigateAsync("AboutUsPage?Id=Home");
        }

        public async void NavigateToVMInitialization()
        {
            await NavigationService.NavigateAsync("VMIntializationMainPage");
        }


        //private async void NavigateToCnt(string path)
        //{
        //    await NavigationService.NavigateAsync(path);
        //}

        //public Task<bool> CanNavigateAsync(INavigationParameters parameters)
        //{
        //    return _pageDialogService.DisplayAlertAsync("Title", "Message", "Ok", "Cancel");
        //}

        public HomePageViewModel(Prism.Navigation.INavigationService navigationService, Prism.Services.Dialogs.IDialogService dialogService/*, IPageDialogService PageDialogService*/) : base(navigationService)
        {
           // _pageDialogService = PageDialogService;
            Title = "Home";
            ShowDialogCommand = new DelegateCommand(async () =>
            {
                dialogService.ShowDialog("NameDialog", CloseDialogCallback);
            });
        }

        public DelegateCommand ShowDialogCommand { get; set; }

        void CloseDialogCallback(IDialogResult dialogResult)
        {

        }
    }
}
