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
    public partial class O_Projeto_Adam : ContentPage
    {
        public O_Projeto_Adam()
        {

            InitializeComponent();

            // Imagem da logo do aplicativo:

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            // Removendo a barra de navegação do aplicativo:

            NavigationPage.SetHasNavigationBar(this, false);

            // Especificando o caminho do poster do filme:

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.O_Projeto_Adam.jpg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' height='315' 
                                 src='https://www.youtube.com/embed/nrlmJv6X0q4' 
                                 title='YouTube video player' frameborder='0' allow='accelerometer; 
                                 autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                 allowfullscreen></iframe>";

            Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "Um viajante do tempo volta ao ano de 2022 por acidente " +
                                 "e acaba se encontrando com seu eu mais novo. Juntos, " +
                                 "e sendo caçados por forças do futuro, " +
                                 "os dois embarcam em uma missão para consertar a linha temporal " +
                                 "e salvar seus entes queridos.";

        }
    }
}
