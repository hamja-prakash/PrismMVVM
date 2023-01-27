using Prism.Commands;
using Prism.Navigation;

namespace XamarinMVVMPrismDemo.ViewModels
{
    public class AboutUsViewModel : BaseViewModel, INavigatedAware
    {
        public DelegateCommand NavigateBackCommand => new DelegateCommand(NavigateBack);
        public DelegateCommand NavigateCommand => new DelegateCommand(Navigate);

        private string _navigateFrom;
        public string NavigateFrom
        {
            get
            {
                return _navigateFrom;
            }
            set
            {
                SetProperty(ref _navigateFrom, value);
            }
        }

        public async void NavigateBack()
        {
            await NavigationService.GoBackAsync();
        }

        public async void Navigate()
        {
            await NavigationService.NavigateAsync("ContactPage");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("Id"))
                NavigateFrom = "Navigate From " + (string)parameters["Id"];
        }

        public AboutUsViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "About Us";
        }
    }
}
