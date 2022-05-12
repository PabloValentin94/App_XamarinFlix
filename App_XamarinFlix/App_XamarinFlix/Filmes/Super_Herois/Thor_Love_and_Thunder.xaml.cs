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
    public partial class Thor_Love_and_Thunder : ContentPage
    {
        public Thor_Love_and_Thunder()
        {

            InitializeComponent();

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Thor_Love_and_Thunder.jpg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' height='315' 
                                 src='https://www.youtube.com/embed/dPcdCZekMQg' 
                                 title='YouTube video player' frameborder='0' allow='accelerometer; 
                                 autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                 allowfullscreen></iframe>";

            Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "Thor: Love and Thunder é um futuro filme estadunidense de super-herói " +
                                 "baseado no personagem Thor da Marvel Comics. Produzido pela Marvel Studios " +
                                 "e distribuído pela Walt Disney Studios Motion Pictures, " +
                                 "será a sequência direta de Thor: Ragnarok, " +
                                 "e o vigésimo nono filme do Universo Cinematográfico Marvel.";

        }
    }
}