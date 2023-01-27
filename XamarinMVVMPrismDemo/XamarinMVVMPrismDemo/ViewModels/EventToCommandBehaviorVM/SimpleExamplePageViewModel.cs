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
    public class SimpleExamplePageViewModel : BaseViewModel
    {
        private readonly IPageDialogService _pageDialogService;

        public SimpleExamplePageViewModel(INavigationService navigationService, IPageDialogService pageDialogService,
                                          IDataProvider dataProvider) : base(navigationService)
        {
            Title = "SimpleExample";
            _pageDialogService = pageDialogService;

            SelectedDeveloperCommand = new DelegateCommand(SelectedDeveloper);

            // Insert test data into collection of Developers
            Developers = new ObservableCollection<Developer>();
            foreach (var person in dataProvider.GetAllData())
            {
                Developers.Add(person);
            }
        }

        public DelegateCommand SelectedDeveloperCommand { get; private set; }

        public ObservableCollection<Developer> Developers { get; set; }

        private async void SelectedDeveloper()
        {
            await _pageDialogService.DisplayAlertAsync("Info.", "Some developer is selected.", "Ok");
        }
    }
}
