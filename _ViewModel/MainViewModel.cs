using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAUI_AlarmasQR._ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public CounterButtonViewModel CounterButton { get; } = new();
    }
}
