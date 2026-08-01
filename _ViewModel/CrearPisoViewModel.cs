using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_AlarmasQR._Model;
using MAUI_AlarmasQR._Model.AlarmaModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MAUI_AlarmasQR._ViewModel
{
    public partial class CrearPisoViewModel : ObservableObject
    {
        public Cliente cliente { get; set; }

        public ObservableCollection<Piso> PisosUI { get; } = new();

        [ObservableProperty]
        public partial string NombrePiso { get; set; } = string.Empty;

        public CrearPisoViewModel(Cliente cliente)
        {
            this.cliente = cliente;

            foreach (Piso pisoDeCl in this.cliente.Pisos)
            {
                PisosUI.Add(pisoDeCl);
            }
        }

        [RelayCommand]
        private void CrearPiso()
        {
            if (string.IsNullOrWhiteSpace(NombrePiso))
                return;

            Piso nuevoPiso = new Piso(NombrePiso);

            cliente.Pisos.Add(nuevoPiso);
            PisosUI.Add(nuevoPiso);

            NombrePiso = string.Empty;
        }

        [RelayCommand]
        private void CrearArea(Piso piso)
        {
            if (piso is null)
                return;

            var nuevaArea = new Area($"Área {piso.Areas.Count + 1}");
            piso.Areas.Add(nuevaArea); // al ser ObservableCollection, el CollectionView se actualiza solo
        }
    }
}
