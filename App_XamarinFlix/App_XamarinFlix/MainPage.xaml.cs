using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using App_XamarinFlix.Categorias; // Ao usarmos o using não precisamos especificar o caminho completo dos arquivos de categorias de filmes.

namespace App_XamarinFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();

            // Imagem da logo do aplicativo:

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            // Removendo a barra de navegação do aplicativo:

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void btn_open_super_herois(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new Super_Herois());
            
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

                await Navigation.PushAsync(new Ficcao_Cientifica());
            
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

                await Navigation.PushAsync(new Comedia());
            
            }
            catch (Exception ex)
            {

                await DisplayAlert("Erro Detectado!", ex.Message, "Ok");
            
            }
            
        }
    }
}
