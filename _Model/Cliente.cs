using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MAUI_AlarmasQR._Model
{
    internal class Cliente
    {
        public string nombre {  get; private set; }
        public ObservableCollection<Alarma> ListaDeAlarmas { get; } = new();
        //public string registroDeMatenimientos { get; private set; } - Esto va a ser una coleccion de los distintos PDF que se fueron exportando de este cliente

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
