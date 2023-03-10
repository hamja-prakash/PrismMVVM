using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMVVMPrismDemo.ViewModels.EventAgr
{
    public class EventAgrBaseModel : BindableBase, INavigationAware, IInitialize, IDestructible
    {
        #region Properties

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #endregion

        #region INavigationAware

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }

        public virtual void OnNavigatedTo(INavigationParameters parameters) { }

        public virtual void Initialize(INavigationParameters parameters) { }

        #endregion

        #region IDestructible

        public virtual void Destroy() { }

        #endregion

    }
}
