using MAUI_AlarmasQR._Model.AlarmaModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MAUI_AlarmasQR._Model
{
    public class Cliente
    {
        public string Nombre {  get; private set; }
        //public string registroDeMatenimientos { get; private set; } - Esto va a ser una coleccion de los distintos PDF que se fueron exportando de este cliente

        public List<Piso> Pisos { get; private set; }

        public Cliente(string Nombre)
        {
            this.Nombre = Nombre;
            this.Pisos = new List<Piso>();
        }

    }
}
