using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Threading.Tasks;

namespace XamarinMVVMPrismDemo.ViewModels.ViewModelInitialization
{
    public class ViewModelInitializationViewModel : BindableBase, IInitialize
    {
        private INavigationService _navigationService { get; }
        private IPageDialogService _dialogs { get; }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set { SetProperty(ref _title, value); }
        }

        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }


        public ViewModelInitializationViewModel(INavigationService navigationService, IPageDialogService dialogs)
        {
            _navigationService = navigationService;
            _dialogs = dialogs;
            Title = "VMIntialization";
            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }

        public DelegateCommand<string> NavigateCommand { get; }

        public async void Initialize(INavigationParameters parameters)
        {
            await Task.Delay(1 * 500);
            Message = "Hello from IInitialize. This won't fire again.";
        }

        private async void OnNavigateCommandExecuted(string path)
        {
            var result = await _navigationService.NavigateAsync(path);

            if (!result.Success)
            {
                await _dialogs.DisplayAlertAsync("Error", result.Exception.Message, "Ok");
            }
        }
    }
}
