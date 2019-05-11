using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcular(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar um nome", "OK");
                return;
            }

            if (string.IsNullOrEmpty(pesoEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar um peso", "OK");
                return;
            }

            if (string.IsNullOrEmpty(alturaEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar uma altura", "OK");
                return;
            }

            string nome = nomeEntry.Text;
            double peso = Convert.ToDouble(pesoEntry.Text);
            double altura = Convert.ToDouble(alturaEntry.Text);

            double imc = peso / (altura * altura);

            if (imc < 17)
            {
                DisplayAlert("Resultado",
                $"{nome} tem {peso}kg e {altura}m.\nIMC={imc.ToString("0.0")}\nResultado = Muito abaixo do Peso",
                "OK");
            }

            if (imc >= 17 && imc <= 18.49)
            {
                DisplayAlert("Resultado",
                $"{nome} tem {peso}kg e {altura}m.\nIMC={imc.ToString("0.0")}\nResultado = Abaixo do Peso",
                "OK");
            }

            if (imc >= 18.5 && imc <= 24.99)
            {
                DisplayAlert("Resultado",
                $"{nome} tem {peso}kg e {altura}m.\nIMC={imc.ToString("0.0")}\nResultado = Peso Normal",
                "OK");
            }

            if (imc >= 25 && imc <= 29.99)
            {
                DisplayAlert("Resultado",
                $"{nome} tem {peso}kg e {altura}m.\nIMC={imc.ToString("0.0")}\nResultado = Acima do Peso",
                "OK");
            }

            if (imc >= 30 && imc <= 34.99)
            {
                DisplayAlert("Resultado",
                $"{nome} tem {peso}kg e {altura}m.\nIMC={imc.ToString("0.0")}\nResultado = Obesidade",
                "OK");
            }

            if (imc >= 35 && imc <= 39.99)
            {
                DisplayAlert("Resultado",
                $"{nome} tem {peso}kg e {altura}m.\nIMC={imc.ToString("0.0")}\nResultado = Obesidade Severa",
                "OK");
            }

            if (imc >= 40)
            {
                DisplayAlert("Resultado",
                $"{nome} tem {peso}kg e {altura}m.\nIMC={imc.ToString("0.0")}\nResultado = Obesidade Mórbida",
                "OK");
            }


        }
    }
}