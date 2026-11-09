using MauiAppHotel.Models; // Necessário para acessar a classe Hospedagem

namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();
    }

    // 
    // 
    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        // 
        await Navigation.PopAsync();
    }
}