using Prism.AppModel;
using Prism.Mvvm;

namespace XamarinMVVMPrismDemo.ViewModels.ViewModelInitialization
{
    public class PageAViewModel : BindableBase, IAutoInitialize
    {
        private string _message;
        [AutoInitialize(true)]
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}
