using System;
using System.Collections.Generic;
using System.Text;

namespace MAUI_AlarmasQR._Model.AlarmaModel
{
    public class Alarma
    {
        public string Nombre {  get; set; }
        public List<Piso> Pisos { get; set; }
        public Alarma(string Nombre)
        {
            this.Pisos = new List<Piso>(); 
            this.Nombre = Nombre;
        }
    }
}
