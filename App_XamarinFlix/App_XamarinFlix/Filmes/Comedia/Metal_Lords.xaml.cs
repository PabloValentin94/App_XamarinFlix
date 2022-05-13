using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_XamarinFlix.Filmes.Comedia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Metal_Lords : ContentPage
    {
        public Metal_Lords()
        {

            InitializeComponent();

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Metal_Lords.jpg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' height='315' 
                                 src='https://www.youtube.com/embed/BZicnf4BckI' 
                                 title='YouTube video player' frameborder='0' allow='accelerometer; 
                                 autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                 allowfullscreen></iframe>";

           Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "Dois garotos formam uma banda de heavy metal na escola, " +
                                 "mas só eles curtem esse som. " +
                                 "Após a tentativa frustrada de encontrar um baixista, " +
                                 "a dupla conhece uma garota que toca violoncelo. " +
                                 "Agora, eles precisam se unir para vencer a Batalha das Bandas.";

        }
    }
}
