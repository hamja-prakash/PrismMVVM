using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMVVMPrismDemo.ViewModels.NavigationModeVM
{
    public class NavigationModeViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public NavigationModeViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Navigation Mode";
            _navigationService = navigationService;
            SecondPageCommand = new DelegateCommand(SecondPageAction);
        }

        public DelegateCommand SecondPageCommand { get; set; }


        private async void SecondPageAction()
        {
            await _navigationService.NavigateAsync("SecondPage");
        }

    }
}
