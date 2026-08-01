using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_AlarmasQR._Model.AlarmaModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MAUI_AlarmasQR._ViewModel
{
    internal class ListaClienteAlarmaAreaPisoViewModel : ObservableObject
    {
        public ObservableCollection<Piso> Pisos { get; } = new();
        public ObservableCollection <Area> Areas { get; } = new();
        public ObservableCollection<Alarma> Alarmas { get; } = new();
    }
}
