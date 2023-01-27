using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMVVMPrismDemo.View.PageLifecycleAware
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageLifecycle1 : ContentPage
	{
		public PageLifecycle1 ()
		{
			InitializeComponent ();
		}
	}
}