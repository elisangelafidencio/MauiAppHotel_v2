namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registra a rota para a tela Sobre
            Routing.RegisterRoute(nameof(Views.Sobre), typeof(Views.Sobre));
        }
    }
}