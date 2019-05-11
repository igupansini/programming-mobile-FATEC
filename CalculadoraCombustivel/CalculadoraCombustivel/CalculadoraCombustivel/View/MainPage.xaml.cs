using CalculadoraCombustivel.Model;
using CalculadoraCombustivel.View;
using System;
using Xamarin.Forms;

namespace CalculadoraCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcular(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(precoEtanolEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar o preço do Etanol!", "OK");
                return;
            }

            if (string.IsNullOrEmpty(consumoMedioEtanolEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar o consumo médio do Etanol!", "OK");
                return;
            }

            if (string.IsNullOrEmpty(precoGasolinaEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar o preço da Gasolina!", "OK");
                return;
            }

            if (string.IsNullOrEmpty(consumoMedioGasolinaEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar o consumo médio da Gasolina!", "OK");
                return;
            }

            Combustivel etanol = new Combustivel();
            etanol.Preco = Convert.ToDouble(precoEtanolEntry.Text);
            etanol.Consumo = Convert.ToDouble(consumoMedioEtanolEntry.Text);

            Combustivel gasolina = new Combustivel();
            gasolina.Preco = Convert.ToDouble(precoGasolinaEntry.Text);
            gasolina.Consumo = Convert.ToDouble(consumoMedioGasolinaEntry.Text);

            Navigation.PushAsync(new ResultadoPage(etanol, gasolina)); 
        }
    }
}
