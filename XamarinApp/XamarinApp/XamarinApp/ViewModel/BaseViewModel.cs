using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinApp.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            var change = PropertyChanged;
            if (change == null)
                return;

            change.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
