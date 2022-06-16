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
    public partial class The_Batman : ContentPage
    {
        public The_Batman()
        {

            InitializeComponent();

            // Imagem da logo do aplicativo:

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            // Removendo a barra de navegação do aplicativo:

            NavigationPage.SetHasNavigationBar(this, false);

            // Especificando o caminho do poster do filme:

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.The_Batman.jpeg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' height='315' 
                                 src='https://www.youtube.com/embed/HJv4LQxbVEA' 
                                 title='YouTube video player' frameborder='0' allow='accelerometer; 
                                 autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                 allowfullscreen></iframe>";

            Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "Após dois anos espreitando as ruas como Batman, " +
                                 "Bruce Wayne se encontra nas profundezas mais sombrias de Gotham City. " +
                                 "Com poucos aliados confiáveis, o vigilante solitário se estabelece " +
                                 "como a personificação da vingança para a população.";

        }
    }
}