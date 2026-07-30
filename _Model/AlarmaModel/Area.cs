using System;
using System.Collections.Generic;
using System.Text;

namespace MAUI_AlarmasQR._Model.AlarmaModel
{
    public class Area
    {
        public string Nombre { get; set; }

        public List<Alarma> Alarmas { get; set; }

        public Area(string Nombre)
        {
            this.Alarmas = new List<Alarma>();
            this.Nombre = Nombre;
        }
    }
}
