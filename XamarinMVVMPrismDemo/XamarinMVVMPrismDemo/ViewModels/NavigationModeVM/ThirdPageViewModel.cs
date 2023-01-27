using Prism.Navigation;

namespace XamarinMVVMPrismDemo.ViewModels.NavigationModeVM
{
    public class ThirdPageViewModel : BaseViewModel
    {
        public ThirdPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Third Page";
        }
    }
}
