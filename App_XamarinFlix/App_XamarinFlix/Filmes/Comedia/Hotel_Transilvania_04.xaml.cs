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
    public partial class Hotel_Transilvania_04 : ContentPage
    {
        public Hotel_Transilvania_04()
        {

            InitializeComponent();

            Logo.Source = ImageSource.FromResource("App_XamarinFlix.Imagem.Xamarin_Logo.png");

            Poster.Source = ImageSource.FromResource("App_XamarinFlix.Posters.Hotel_Transilvania_04.jpg");

            /*var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<iframe width='560' 
                                        height='315' 
                                        src='https://www.youtube.com/embed/bKOoGVZHQ3E' 
                                        title='YouTube video player' 
                                        frameborder='0' 
                                        allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' 
                                        allowfullscreen></iframe>";

            Visualizador.Source = htmlSource;*/

            Sinopse_Filme.Text = "A nova invenção de Van Helsing transforma Drac e os amigos em humanos, " + 
                                 "e Johnny em um monstro. Agora, Drac deve encontrar uma maneira de reverter o feitiço " + 
                                 "antes que a mudança se torne permanente.";

        }
    }
}