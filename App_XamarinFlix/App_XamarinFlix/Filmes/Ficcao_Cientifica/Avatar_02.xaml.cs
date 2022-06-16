using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_XamarinFlix.Filmes.Ficcao_Cientifica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Avatar_02 : ContentPage
    {
        public Avatar_02()
        {

            InitializeComponent();

            // Imagem da logo do aplicativo:

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            // Removendo a barra de navegação do aplicativo:

            NavigationPage.SetHasNavigationBar(this, false);

            // Especificando o caminho do poster do filme:

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Avatar_02.jpg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' height='315' 
                                 src='https://www.youtube.com/embed/-cmwzbZ072U' 
                                 title='YouTube video player' frameborder='0' allow='accelerometer; 
                                 autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                 allowfullscreen></iframe>";

            Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "Avatar: The Way of Water é um futuro filme épico de ficção científica americano " +
                                 "co-escrito, co-editado, co-produzido e dirigido por James Cameron, " +
                                 "e produzido pela 20th Century Studios, com sua data de lançamento prevista " +
                                 "para 15 de dezembro de 2022, no Brasil. Será a sequência de Avatar.";

        }
    }
}
