using Prism.AppModel;
using Prism.Mvvm;

namespace XamarinMVVMPrismDemo.ViewModels.PopupVM
{
    public class SamplePopupViewModel : BindableBase, IAutoInitialize
    {
        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}
