using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMVVMPrismDemo.ViewModels.NavigationModeVM
{
    public class SecondPageViewModel : BaseViewModel, INavigatedAware
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand ThirdPageCommand { get; }

        private NavigationMode _navigationMode;
        public NavigationMode NavigationMode
        {
            get { return _navigationMode; }
            set { SetProperty(ref _navigationMode, value); }
        }
        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Second Page";
            _navigationService = navigationService;
            ThirdPageCommand = new DelegateCommand(ThirdPageAction);
        }

        private bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; }
            set { SetProperty(ref _isVisible, value); }
        }

        private async void ThirdPageAction()
        {
            await _navigationService.NavigateAsync("ThirdPage");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            NavigationMode = parameters.GetNavigationMode();
            IsVisible = NavigationMode == NavigationMode.Back ? true : false;
        }
    }
}
