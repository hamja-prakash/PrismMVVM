using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace XamarinMVVMPrismDemo.ViewModels
{
    public class ContactViewModel : BaseViewModel
    {
        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value); }
        }
        public DelegateCommand<string> ButtonClickCommand => new DelegateCommand<string>(Execute).ObservesCanExecute(() => IsActive);
        public ContactViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Contact Us";
        }

        private void Execute(string parameter= "")
        {
        }
    }
}
