using Prism.Mvvm;
using Prism.Navigation;

namespace XamarinMVVMPrismDemo.ViewModels.XAMLNavigation
{
    public class InformationPageViewModel : BaseViewModel, INavigationAware
    {
        private string _text;

        public InformationPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Information";
        }

        public string Text
        {
            get { return _text; }
            set
            {
                SetProperty(ref _text, value);
            }
        }

       

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("Message"))
            {
                Text = parameters.GetValue<string>("Message");
            }

            if (parameters.ContainsKey("MoreMessages"))
            {
                Text += " " + parameters.GetValue<string>("MoreMessages");
            }
        }
    }
}
