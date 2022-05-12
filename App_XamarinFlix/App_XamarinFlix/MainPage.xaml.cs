using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_XamarinFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void btn_open_super_herois(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new Categorias.Super_Herois());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro Detectado!", ex.Message, "Ok");
            }

        }

        private async void btn_open_ficcao_cientifica(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new Categorias.Ficcao_Cientifica());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro Detectado!", ex.Message, "Ok");
            }

        }

        private async void btn_open_comedia(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new Categorias.Comedia());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro Detectado!", ex.Message, "Ok");
            }
            
        }
    }
}
