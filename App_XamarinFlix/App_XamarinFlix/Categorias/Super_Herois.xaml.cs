using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_XamarinFlix.Filmes.Super_Herois; // Ao usarmos o using não precisamos especificar o caminho completo dos arquivos de filmes.

namespace App_XamarinFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Super_Herois : ContentPage
    {
        public Super_Herois()
        {

            InitializeComponent();

            // Imagem da logo do aplicativo:

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            // Removendo a barra de navegação do aplicativo:

            NavigationPage.SetHasNavigationBar(this, false);

            // Imagens dos posteres:

            btn_black_panther_wakanda_forever.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Black_Panther_Wakanda_Forever.jpg");

            btn_doutor_estranho_02.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Doutor_Estranho_02.jpg");

            btn_morbius.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Morbius.jpg");

            btn_the_batman.Source = ImageSource.FromResource("App_XamarinFlix.Posters.The_Batman.jpeg");

            btn_thor_love_and_thunder.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Thor_Love_and_Thunder.jpg");

        }

        private async void btn_black_panther_wakanda_forever_Clicked(object sender, EventArgs e)
        {
            
            try
            {

                await Navigation.PushAsync(new Black_Panther_Wakanda_Forever());

            }
            catch(Exception ex)
            {

                await DisplayAlert("Erro Detectado!", ex.Message, "OK");

            }

        }

        private async void btn_doutor_estranho_02_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new Doutor_Estranho_02());
            
            }
            catch (Exception ex)
            {

                await DisplayAlert("Erro Detectado!", ex.Message, "OK");
            
            }

        }

        private async void btn_morbius_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new Morbius());
            
            }
            catch (Exception ex)
            {

                await DisplayAlert("Erro Detectado!", ex.Message, "OK");
            
            }

        }

        private async void btn_the_batman_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new The_Batman());
            
            }
            catch (Exception ex)
            {

                await DisplayAlert("Erro Detectado!", ex.Message, "OK");
            
            }

        }

        private async void btn_thor_love_and_thunder_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new Thor_Love_and_Thunder());

            }
            catch (Exception ex)
            {

                await DisplayAlert("Erro Detectado!", ex.Message, "OK");
            
            }

        }
    }
}