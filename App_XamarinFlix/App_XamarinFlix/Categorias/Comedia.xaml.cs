using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_XamarinFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {

            InitializeComponent();

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            btn_hotel_transilvania_04.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Hotel_Transilvania_04.jpg");

            btn_metal_lords.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Metal_Lords.jpg");

            btn_red_cresecer_e_uma_fera.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Red_Crescer_e_Uma_Fera.jpg");

        }

        private async void btn_hotel_transilvania_04_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new Filmes.Comedia.Hotel_Transilvania_04());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro Detectado!", ex.Message, "Ok");
            }
          
        }

        private async void btn_metal_lords_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new Filmes.Comedia.Metal_Lords());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro Detectado!", ex.Message, "Ok");
            }

        }

        private async void btn_red_cresecer_e_uma_fera_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new Filmes.Comedia.Red_Crescer_E_Uma_Fera());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro Detectado!", ex.Message, "Ok");
            }

        }
    }
}