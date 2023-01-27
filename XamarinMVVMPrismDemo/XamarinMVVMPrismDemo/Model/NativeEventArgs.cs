using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMVVMPrismDemo.Model
{
    public class NativeEventArgs : EventArgs
    {
        public string Message { get; set; }

        public NativeEventArgs(string message)
        {
            Message = message;
        }
    }
}
