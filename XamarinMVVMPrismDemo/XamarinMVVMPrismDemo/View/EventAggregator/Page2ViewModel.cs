using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System.Windows.Input;
using XamarinMVVMPrismDemo.Model;
using XamarinMVVMPrismDemo.Navigate;
using XamarinMVVMPrismDemo.ViewModels.EventAgr;

namespace XamarinMVVMPrismDemo.View.EventAggregator
{
    public class Page2ViewModel : EventAgrBaseModel
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;

        public Page2ViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;

            Title = "So what do you think?";
            SubmitCommand = new DelegateCommand(OnSubmitTapped);
        }

        private bool _isFun;
        public bool IsFun
        {
            get => _isFun;
            set => SetProperty(ref _isFun, value, () => _eventAggregator.GetEvent<IsFunChangedEvent>().Publish(value));
        }

        public ICommand SubmitCommand { get; }

        private void OnSubmitTapped()
        {
            _navigationService.GoBackAsync();
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey(NavigationParameterKeys.CurrentIsFunValue))
            {
                IsFun = parameters.GetValue<bool>(NavigationParameterKeys.CurrentIsFunValue);
            }
        }
    }
}
