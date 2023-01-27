using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMVVMPrismDemo.View.DialogueView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NameDialog : Frame
    {
        public NameDialog()
        {
            InitializeComponent();
        }
    }
}