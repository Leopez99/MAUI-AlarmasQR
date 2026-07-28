using MAUI_AlarmasQR._ViewModel;

namespace MAUI_AlarmasQR;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCrearAlarmaClicked(object sender, EventArgs e)
    {
        // await Navigation.PushAsync(new CrearAlarmaPage());
    }

    private async void OnComenzarMantenimientoClicked(object sender, EventArgs e)
    {
        // await Navigation.PushAsync(new MantenimientoPage());
    }
}
