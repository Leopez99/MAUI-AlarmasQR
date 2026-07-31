using System;
using System.Collections.Generic;
using System.Text;

namespace MAUI_AlarmasQR._Model.AlarmaModel
{
    public class Alarma
    {
        public string Nombre { get; set; }
        public bool Funciona { get; private set; }
        public string NotaAdicional { get; set; }

        public Alarma(string Nombre)
        {
            this.Nombre = Nombre;
            this.Funciona = false;
            this.NotaAdicional = String.Empty;
        }

        public bool checkear()
        {
            return !this.Funciona;
        }
    }
}
