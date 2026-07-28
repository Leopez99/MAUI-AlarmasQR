using System;
using System.Collections.Generic;
using System.Text;

namespace MAUI_AlarmasQR._Model
{
    internal class Alarma
    {
        public string piso { get; private set; }
        public string area { get; private set; }
        public string nombre { get; private set; }

        public Alarma(string piso, string area, string nombre)
        {
            this.piso = piso;
            this.area = area;
            this.nombre = nombre;
        }
    }
}
