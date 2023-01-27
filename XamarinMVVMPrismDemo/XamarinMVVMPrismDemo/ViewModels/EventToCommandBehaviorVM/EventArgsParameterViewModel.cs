using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinMVVMPrismDemo.Model;
using XamarinMVVMPrismDemo.Navigate;

namespace XamarinMVVMPrismDemo.ViewModels.EventToCommandBehaviorVM
{
    public class EventArgsParameterViewModel : BaseViewModel
    {
        private readonly IPageDialogService _pageDialogService;

        public ObservableCollection<Developer> Developers { get; set; }

        public DelegateCommand<Developer> SelectedDeveloperCommand { get; private set; }

        public EventArgsParameterViewModel(IPageDialogService pageDialogService,
            IDataProvider dataProvider, INavigationService navigationService): base(navigationService)
        {
            Title = "EventArgsParameter";
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
