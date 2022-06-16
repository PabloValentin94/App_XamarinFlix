using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_XamarinFlix.Filmes.Super_Herois
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Morbius : ContentPage
    {
        public Morbius()
        {

            InitializeComponent();

            // Imagem da logo do aplicativo:

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            // Removendo a barra de navegação do aplicativo:

            NavigationPage.SetHasNavigationBar(this, false);

            // Especificando o caminho do poster do filme:

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Morbius.jpg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' height='315' 
                                 src='https://www.youtube.com/embed/oYXCjJa_aBg' 
                                 title='YouTube video player' frameborder='0' allow='accelerometer; 
                                 autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                 allowfullscreen></iframe>";

            Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "O bioquímico Michael Morbius tenta curar-se de uma doença rara no sangue, mas, " +
                                 "sem perceber, ele fica infectado com uma forma de vampirismo.";

        }
    }
}