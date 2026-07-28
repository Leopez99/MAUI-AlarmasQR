using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_AlarmasQR._Model;
using MAUI_AlarmasQR._ViewModel;
using System.Collections.ObjectModel;

namespace MAUI_AlarmasQR._View
{
    public partial class CrearCliente : ContentPage
    {
        public ObservableCollection<Cliente> ListaDeClientes { get; } = new();

        public CrearCliente()
        {
            InitializeComponent();
            BindingContext = new CrearClienteViewModel();
        }
    }
}