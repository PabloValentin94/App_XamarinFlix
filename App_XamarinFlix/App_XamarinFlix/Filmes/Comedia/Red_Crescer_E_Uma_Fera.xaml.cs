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
    public partial class Red_Crescer_E_Uma_Fera : ContentPage
    {
        public Red_Crescer_E_Uma_Fera()
        {

            InitializeComponent();

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Red_Crescer_e_Uma_Fera.jpg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/YeQoQNZq7wg' 
                                        title='YouTube video player' 
                                        frameborder='0' allow='accelerometer; 
                                        autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                        allowfullscreen></iframe>";

            Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "Uma menina de 13 anos começa a se transformar em " +
                                 "um panda vermelho gigante sempre que fica animada.";

        }
    }
}