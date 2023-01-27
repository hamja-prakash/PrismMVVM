using Prism.Mvvm;
using Prism.Navigation;

namespace XamarinMVVMPrismDemo.ViewModels.XAMLNavigation
{
    public class XAMLMainPageViewModel : BaseViewModel
    {
        public XAMLMainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "XAMLNavigation";
        }
    }
}
