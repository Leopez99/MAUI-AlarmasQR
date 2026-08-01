using MAUI_AlarmasQR._Model;
using MAUI_AlarmasQR._Model.AlarmaModel;
using MAUI_AlarmasQR._ViewModel;

namespace MAUI_AlarmasQR._View;

public partial class CrearPisos : ContentPage
{
	public CrearPisos()
	{
		InitializeComponent();
		BindingContext = new CrearPisoViewModel(new Cliente("Piso de prueba"));
	}
}