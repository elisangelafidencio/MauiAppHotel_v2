namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        // Volta para a tela anterior usando a pilha de navegação
        await Navigation.PopAsync();
    }
}