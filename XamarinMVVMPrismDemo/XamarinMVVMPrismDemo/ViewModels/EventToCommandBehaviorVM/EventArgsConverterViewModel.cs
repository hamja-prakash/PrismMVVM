using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Collections.ObjectModel;
using XamarinMVVMPrismDemo.Model;
using XamarinMVVMPrismDemo.Navigate;

namespace XamarinMVVMPrismDemo.ViewModels.EventToCommandBehaviorVM
{
    public class EventArgsConverterViewModel : BaseViewModel
    {
        private readonly IPageDialogService _pageDialogService;

        public ObservableCollection<Developer> Developers { get; set; }

        public DelegateCommand<Developer> SelectedDeveloperCommand { get; private set; }

        public EventArgsConverterViewModel(IPageDialogService pageDialogService,
            IDataProvider dataProvider, INavigationService navigationService) : base(navigationService)
        {
            Title = "EventArgsConverter";
            _pageDialogService = pageDialogService;

            SelectedDeveloperCommand = new DelegateCommand<Developer>(SelectedDeveloper);

            // Insert test data into collection of Developers
            Developers = new ObservableCollection<Developer>();
            foreach (var developer in dataProvider.GetAllData())
            {
                Developers.Add(developer);
            }
        }

        private async void SelectedDeveloper(Developer developer)
        {
            await _pageDialogService.DisplayAlertAsync("Info", $"{developer.FullName} from {developer.Country} is selected.", "Ok");
        }
    }
}
