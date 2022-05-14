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
    public partial class Black_Panther_Wakanda_Forever : ContentPage
    {
        public Black_Panther_Wakanda_Forever()
        {

            InitializeComponent();

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Black_Panther_Wakanda_Forever.jpg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' height='315' 
                                 src='https://www.youtube.com/embed/qZuQc-GvRlk' 
                                 title='YouTube video player' frameborder='0' allow='accelerometer; 
                                 autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                 allowfullscreen></iframe>";

             Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "Black Panther: Wakanda Forever é um futuro filme estadunidense " +
                                 "de super-herói baseado no personagem Pantera Negra da Marvel Comics. " +
                                 "Produzido pelo Marvel Studios e distribuído pela Walt Disney Studios Motion Pictures, " +
                                 "é a sequência de Pantera Negra e o trigésimo filme do " +
                                 "Universo Cinematográfico Marvel (UCM).";

        }
    }
}