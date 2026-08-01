using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MAUI_AlarmasQR._Model.AlarmaModel
{
    public class Piso
    {
        public string Nombre { get; set; }
        public ObservableCollection<Area> Areas { get; private set; }

        public Piso(string Nombre)
        {
            this.Nombre = Nombre;
            this.Areas = new ObservableCollection<Area>();
        }
    }
}
