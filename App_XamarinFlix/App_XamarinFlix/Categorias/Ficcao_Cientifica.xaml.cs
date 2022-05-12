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
    public partial class Ficcao_Cientifica : ContentPage
    {
        public Ficcao_Cientifica()
        {

            InitializeComponent();

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            btn_o_projeto_adam.Source = ImageSource.FromResource("App_XamarinFlix.Posters.O_Projeto_Adam.jpg");

        }

        private void btn_o_projeto_adam_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Filmes.Ficcao_Cientifica.O_Projeto_Adam());

        }
    }
}