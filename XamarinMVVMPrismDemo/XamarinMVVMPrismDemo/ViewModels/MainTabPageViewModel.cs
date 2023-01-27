using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMVVMPrismDemo.ViewModels
{
    public class MainTabPageViewModel : BindableBase
    {
        private IApplicationCommands _applicationCommand;
        public IApplicationCommands ApplicationCommands
        {
            get { return _applicationCommand; }
            set { SetProperty(ref _applicationCommand, value); }
        }

        public MainTabPageViewModel(IApplicationCommands applicationCommands)
        {
            ApplicationCommands = applicationCommands;
        }
    }
}
