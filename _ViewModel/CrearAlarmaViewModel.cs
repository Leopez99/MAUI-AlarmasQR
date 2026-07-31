using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_AlarmasQR._Model;
using MAUI_AlarmasQR._Model.AlarmaModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAUI_AlarmasQR._ViewModel
{
    internal partial class CrearAlarmaViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial Cliente ClienteSeleccionado { get; set; }

        [ObservableProperty]
        public partial string NombreAlarma { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string NombrePiso { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string NombreArea { get; set; } = string.Empty;

        // new Alarma()
        // new Area()
        // new Piso()
        // A la lista de Cliente agregar Piso
        // A la lista de Piso agregar Area
        // A la lista de Area agregar Alamar

        [RelayCommand]
        private void GuardarAlarma()
        {
            if (ClienteSeleccionado is null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(NombrePiso) || string.IsNullOrWhiteSpace(NombreArea) || string.IsNullOrWhiteSpace(NombreAlarma))
            {
                return;
            }

            try
            {
                Piso nuevoPiso = new Piso(NombrePiso);
                ClienteSeleccionado.Pisos.Add(nuevoPiso);

                Area nuevaArea = new Area(NombreArea);
                nuevoPiso.Areas.Add(nuevaArea);

                Alarma nuevaAlarma = new Alarma(NombreAlarma);
                nuevaArea.Alarmas.Add(nuevaAlarma);
            }
            catch (ArgumentException ex)
            {
                // Error con algun Label
            }
        }

    }
}
