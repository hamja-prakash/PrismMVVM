using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinMVVMPrismDemo.ViewModels.DeviceServiceVM
{
    public class DeviceServiceMainPageViewModel : BaseViewModel
    {
        private readonly IDeviceService _deviceService;

        public DeviceServiceMainPageViewModel(INavigationService navigationService, IDeviceService deviceService) : base(navigationService)
        {
            Title = "DeviceService";
            _deviceService = deviceService;
            RuntimePlatform = _deviceService.RuntimePlatform;
            Idiom = _deviceService.Idiom;
        }

        public TargetIdiom Idiom { get; }
        public RuntimePlatform RuntimePlatform { get; }
    }
}
