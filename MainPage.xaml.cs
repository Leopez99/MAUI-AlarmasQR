using MAUI_AlarmasQR._ViewModel;

namespace MAUI_AlarmasQR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
