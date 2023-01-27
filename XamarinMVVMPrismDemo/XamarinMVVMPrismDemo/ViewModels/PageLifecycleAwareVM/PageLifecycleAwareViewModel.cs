using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMVVMPrismDemo.ViewModels.PageLifecycleAwareVM
{
    public class PageLifecycleAwareViewModel : BaseViewModel
    {
        public PageLifecycleAwareViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "PageLifeCycleAware";
        }
    }
}
