using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_AlarmasQR._Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MAUI_AlarmasQR._ViewModel
{
    internal partial class CrearClienteViewModel : ObservableObject
    {
        [ObservableProperty]
        private string nombreCliente;
        public ObservableCollection<Cliente> ListaDeClientes { get; } = new();

        [RelayCommand]
        private void AgregarCliente()
        {
            if (string.IsNullOrWhiteSpace(NombreCliente))
                return;

            Cliente cl = new Cliente(nombreCliente);
            ListaDeClientes.Add(cl);
            NombreCliente = string.Empty;
        }
    }
}
