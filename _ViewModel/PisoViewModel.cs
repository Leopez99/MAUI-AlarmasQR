using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_AlarmasQR._Model.AlarmaModel;
using System.Collections.ObjectModel;

namespace MAUI_AlarmasQR._ViewModel
{
    // ============================================================
    // Adaptador (patrón ViewModel por ítem):
    // el MODELO sigue con List<> (datos puros), y este wrapper es
    // el que expone ObservableCollection a la UI.
    // No copia datos: guarda la REFERENCIA al Piso del modelo.
    // ============================================================
    public partial class PisoViewModel : ObservableObject
    {
        // Referencia al modelo real (una sola fuente de verdad)
        public Piso Model { get; }

        public string Nombre => Model.Nombre;

        // Proyección observable: la UI se entera cuando cambia
        public ObservableCollection<Area> Areas { get; } = new();

        public PisoViewModel(Piso piso)
        {
            Model = piso;

            // Copia inicial: lo que ya tenía el modelo, lo ve la UI
            foreach (var area in piso.Areas)
                Areas.Add(area);
        }

        // Único punto por donde se agregan áreas:
        // 1) el modelo guarda el dato  2) la UI se actualiza sola
        public void AgregarArea(Area area)
        {
            Model.Areas.Add(area);
            Areas.Add(area);
        }
    }
}
