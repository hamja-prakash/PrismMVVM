using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;

namespace XamarinMVVMPrismDemo.ViewModels.PageLifecycleAwareVM
{
    public class PageLifecycle1ViewModel : BaseViewModel, IPageLifecycleAware
    {
        IPageDialogService _pageDialogService;
        public PageLifecycle1ViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            Title = "PageLifecycle1";
            _pageDialogService = pageDialogService;
        }

        public void OnAppearing()
        {
            _pageDialogService.DisplayAlertAsync("Title", "OnAppearing fired", "Ok", "Cancel");
            //System.Diagnostics.Debug.WriteLine("OnAppearing fired");
            //System.Diagnostics.Debugger.Break();
        }

        public void OnDisappearing()
        {
            _pageDialogService.DisplayAlertAsync("Title", "OnDisappearing fired", "Ok", "Cancel");
            //System.Diagnostics.Debugger.Break();
        }
    }
}
