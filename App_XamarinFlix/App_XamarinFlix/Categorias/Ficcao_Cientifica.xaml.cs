using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_XamarinFlix.Filmes.Ficcao_Cientifica; // Ao usarmos o using não precisamos especificar o caminho completo dos arquivos de filmes.

namespace App_XamarinFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ficcao_Cientifica : ContentPage
    {
        public Ficcao_Cientifica()
        {

            InitializeComponent();

            // Imagem da logo do aplicativo:

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            // Removendo a barra de navegação do aplicativo:

            NavigationPage.SetHasNavigationBar(this, false);

            // Imagens dos posteres:

            btn_o_projeto_adam.Source = ImageSource.FromResource("App_XamarinFlix.Posters.O_Projeto_Adam.jpg");

            btn_avatar_02.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Avatar_02.jpg");

        }

        private async void btn_o_projeto_adam_Clicked(object sender, EventArgs e)
        {
            try
            {

                await Navigation.PushAsync(new O_Projeto_Adam());
            
            }
            catch(Exception ex)
            {

                await DisplayAlert("Erro Detectado!", ex.Message, "OK");
            
            }

        }

        private async void btn_avatar_02_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new Avatar_02());
            
            }
            catch (Exception ex)
            {

                await DisplayAlert("Erro Detectado!", ex.Message, "OK");
            
            }

        }
    }
}