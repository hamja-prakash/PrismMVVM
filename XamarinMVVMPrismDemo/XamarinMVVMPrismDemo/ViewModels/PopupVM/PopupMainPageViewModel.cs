using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinMVVMPrismDemo.Model;

namespace XamarinMVVMPrismDemo.ViewModels.PopupVM
{
    public class PopupMainPageViewModel : BaseViewModel
    {
        private INavigationService _navigationService { get; }
        private IDialogService _dialogService { get; }

        public PopupMainPageViewModel(INavigationService navigationService, IDialogService dialogService) : base(navigationService)
        {
            Title = "PopupMainPage";
            _dialogService = dialogService;
            _navigationService = navigationService;

            ShowPopupCommand = new DelegateCommand(OnShowPopupCommand);
            ShowDialogCommand = new DelegateCommand(async () =>
            {
                dialogService.ShowDialog("NameDialog", CloseDialogCallback);
            });
        }

        void CloseDialogCallback(IDialogResult dialogResult)
        {

        }

        private string _message = "Hello from MainPage";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public DelegateCommand ShowPopupCommand { get; }

        public DelegateCommand ShowDialogCommand { get; }

        private async void OnShowPopupCommand()
        {
            var result = await _navigationService.NavigateAsync("SamplePopup", ("message", Message));
            if (!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
