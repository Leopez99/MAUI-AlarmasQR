using MAUI_AlarmasQR._ViewModel;
using MAUI_AlarmasQR._View;
namespace MAUI_AlarmasQR;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCrearAlarmaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CrearCliente());
    }

    private async void OnComenzarMantenimientoClicked(object sender, EventArgs e)
    {
        // await Navigation.PushAsync(new MantenimientoPage());
    }
}
