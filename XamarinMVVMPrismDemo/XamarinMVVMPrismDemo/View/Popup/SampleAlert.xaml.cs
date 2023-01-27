using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMVVMPrismDemo.View.Popup
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SampleAlert : Grid
	{
		public SampleAlert ()
		{
			InitializeComponent ();
		}
	}
}