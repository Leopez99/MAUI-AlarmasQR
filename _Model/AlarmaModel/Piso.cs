using System;
using System.Collections.Generic;
using System.Text;

namespace MAUI_AlarmasQR._Model.AlarmaModel
{
    public class Piso
    {
        public string Nombre { get; set; }
        public List<Area> Areas { get; private set; }

        public Piso(string Nombre)
        {
            this.Nombre = Nombre;
            this.Areas = new List<Area>();
        }
    }
}
