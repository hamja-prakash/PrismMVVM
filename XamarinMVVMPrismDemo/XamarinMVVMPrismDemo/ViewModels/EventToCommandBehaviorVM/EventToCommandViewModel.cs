using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace XamarinMVVMPrismDemo.ViewModels.EventToCommandBehaviorVM
{
    public class EventToCommandViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public EventToCommandViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "EventToCommand";
            _navigationService = navigationService;
            GoToEventArgsConverterExamplePageCommand = new DelegateCommand(GoToEventArgsConverterExamplePage);
            GoToEventArgsParameterExamplePageCommand = new DelegateCommand(GoToEventArgsParameterExamplePage);
            GoToSimpleExamplePageCommand = new DelegateCommand(GoToSimpleExamplePage);
        }

        public DelegateCommand GoToEventArgsConverterExamplePageCommand { get; private set; }
        public DelegateCommand GoToEventArgsParameterExamplePageCommand { get; private set; }
        public DelegateCommand GoToSimpleExamplePageCommand { get; private set; }

        private async void GoToEventArgsConverterExamplePage()
        {
            await _navigationService.NavigateAsync("EventArgsConverterExamplePage");
        }

        private async void GoToEventArgsParameterExamplePage()
        {
            await _navigationService.NavigateAsync("EventArgsParameterExamplePage");
        }

        private async void GoToSimpleExamplePage()
        {
            await _navigationService.NavigateAsync("SimpleExamplePage");
        }
    }
}
