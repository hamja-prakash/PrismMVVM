using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMVVMPrismDemo.ViewModels.MasterDetails
{
    public class MasterDetailPageViewModel : BindableBase
    {
        private INavigationService _navigationService { get; }

        public MasterDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(NavigateCommandExecuted);
        }

        public DelegateCommand<string> NavigateCommand { get; }

        private async void NavigateCommandExecuted(string view)
        {
            var result = await _navigationService.NavigateAsync($"NavigationPage/{view}");
            if (!result.Success)
            {
                System.Diagnostics.Debug.WriteLine(result.Exception);
                //System.Diagnostics.Debugger.Break();
            }
        }
    }
}
