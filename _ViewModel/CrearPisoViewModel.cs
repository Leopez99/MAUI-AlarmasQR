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

        // Ahora la UI trabaja con wrappers, no con el modelo directo
        public ObservableCollection<PisoViewModel> PisosUI { get; } = new();

        [ObservableProperty]
        public partial string NombrePiso { get; set; } = string.Empty;

        public CrearPisoViewModel(Cliente cliente)
        {
            this.cliente = cliente;

            foreach (Piso pisoDeCl in this.cliente.Pisos)
            {
                // Se envuelve cada piso del modelo: el modelo no cambia (sigue List<>)
                PisosUI.Add(new PisoViewModel(pisoDeCl));
            }
        }

        [RelayCommand]
        private void CrearPiso()
        {
            if (string.IsNullOrWhiteSpace(NombrePiso))
                return;

            Piso nuevoPiso = new Piso(NombrePiso);

            // 1) el modelo guarda el dato
            cliente.Pisos.Add(nuevoPiso);

            // 2) la UI recibe el wrapper (que apunta al mismo piso)
            PisosUI.Add(new PisoViewModel(nuevoPiso));

            NombrePiso = string.Empty;
        }

        [RelayCommand]
        private void CrearArea(PisoViewModel piso)
        {
            if (piso is null)
                return;

            var nuevaArea = new Area($"Área {piso.Areas.Count + 1}");

            // El wrapper sincroniza modelo + UI en un solo lugar
            piso.AgregarArea(nuevaArea);
        }
    }
}
