using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_AlarmasQR._Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MAUI_AlarmasQR._ViewModel
{
    public partial class ListadoDeClientesViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Cliente> listadoCliente = new ObservableCollection<Cliente>();
    }
}
