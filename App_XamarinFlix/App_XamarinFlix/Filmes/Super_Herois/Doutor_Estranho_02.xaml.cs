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
    public partial class Doutor_Estranho_02 : ContentPage
    {
        public Doutor_Estranho_02()
        {

            InitializeComponent();

            // Imagem da logo do aplicativo:

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            // Removendo a barra de navegação do aplicativo:

            NavigationPage.SetHasNavigationBar(this, false);

            // Especificando o caminho do poster do filme:

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Doutor_Estranho_02.jpg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' height='315' 
                                 src='https://www.youtube.com/embed/X23XCFgdh2M' 
                                 title='YouTube video player' frameborder='0' allow='accelerometer; 
                                 autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                 allowfullscreen></iframe>";

            Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "O aguardado filme trata da jornada do Doutor Estranho rumo ao desconhecido. " +
                                  "Além de receber ajuda de novos aliados místicos e outros já conhecidos do público, " +
                                  "o personagem atravessa as realidades alternativas incompreensíveis e perigosas do Multiverso " +
                                  "para enfrentar um novo e misterioso adversário.";

        }
    }
}