using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;

namespace XamarinMVVMPrismDemo.ViewModels
{
    public class BaseViewModel : BindableBase
    {
        protected INavigationService NavigationService { get; set; }
        protected IEventAggregator EventAggregator { get; set; }
        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set { SetProperty(ref _title, value); }
        }
    }
}
