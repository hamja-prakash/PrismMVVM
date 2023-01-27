using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using XamarinMVVMPrismDemo.Model;

namespace XamarinMVVMPrismDemo.ViewModels.EventAgr
{
    public class EventAggeregatorMainPageViewModel: EventAgrBaseModel
    {
        private readonly INavigationService _navigationService;
        private IEventAggregator _eventAggregator;
        public EventAggeregatorMainPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;
            Title = "Prism.Forms EventAggregator";
            LocalCommand = new DelegateCommand(OnLocalCommandTapped);
            NativeCommand = new DelegateCommand(OnNativeCommandTapped);
        }

        #region Commands

        public ICommand LocalCommand { get; }

        private void OnLocalCommandTapped()
        {
            _navigationService.NavigateAsync("Page1");
        }

        public ICommand NativeCommand { get; }

        private void OnNativeCommandTapped()
        {
            _eventAggregator.GetEvent<NativeEvent>().Publish(new NativeEventArgs("Xamarin.Forms"));
        }

        #endregion
    }
}
