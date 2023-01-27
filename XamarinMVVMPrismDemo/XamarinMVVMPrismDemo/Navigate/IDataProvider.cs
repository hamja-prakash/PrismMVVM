using System;
using System.Collections.Generic;
using System.Text;
using XamarinMVVMPrismDemo.Model;

namespace XamarinMVVMPrismDemo.Navigate
{
    public interface IDataProvider
    {
        List<Developer> GetAllData();
    }
}
