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
    public partial class Super_Herois : ContentPage
    {
        public Super_Herois()
        {

            InitializeComponent();

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            btn_black_panther_wakanda_forever.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Black_Panther_Wakanda_Forever.jpg");

            btn_doutor_estranho_02.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Doutor_Estranho_02.jpg");

            btn_morbius.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Morbius.jpg");

            btn_the_batman.Source = ImageSource.FromResource("App_XamarinFlix.Posters.The_Batman.jpeg");

            btn_thor_love_and_thunder.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Thor_Love_and_Thunder.jpg");

        }

        private void btn_black_panther_wakanda_forever_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new Filmes.Super_Herois.Black_Panther_Wakanda_Forever());

        }

        private void btn_doutor_estranho_02_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Filmes.Super_Herois.Doutor_Estranho_02());

        }

        private void btn_morbius_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Filmes.Super_Herois.Morbius());
        }

        private void btn_the_batman_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Filmes.Super_Herois.The_Batman());

        }

        private void btn_thor_love_and_thunder_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Filmes.Super_Herois.Thor_Love_and_Thunder());

        }
    }
}