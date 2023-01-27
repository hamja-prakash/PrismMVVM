using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
using System.Windows.Input;
using XamarinMVVMPrismDemo.Model;
using XamarinMVVMPrismDemo.Navigate;

namespace XamarinMVVMPrismDemo.ViewModels.EventAgr
{
    public class Page1ViewModel : EventAgrBaseModel
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;

        public Page1ViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;

            Title = "Your Feedback (Read only)";

            _eventAggregator.GetEvent<IsFunChangedEvent>().Subscribe(IsFunChanged);
            EntryCommand = new DelegateCommand(OnEntryCommandTapped);
            GoBackCommand = new DelegateCommand(OnGoBackCommandTapped);
        }

        public void IsFunChanged(bool isFun)
        {
            IsFun = isFun;
        }

        #region Properties

        private bool _isFun;
        public bool IsFun
        {
            get => _isFun;
            set => SetProperty(ref _isFun, value);
        }

        #endregion

        #region Commands

        public ICommand EntryCommand { get; }

        private void OnEntryCommandTapped()
        {
            _navigationService.NavigateAsync("Page2", (NavigationParameterKeys.CurrentIsFunValue, IsFun));
        }

        public ICommand GoBackCommand { get; }

        private void OnGoBackCommandTapped()
        {
            _navigationService.GoBackAsync();
        }
        #endregion

        #region Overrides

        public override void Destroy()
        {
            _eventAggregator.GetEvent<IsFunChangedEvent>().Unsubscribe(IsFunChanged);
        }

        #endregion
    }
}
