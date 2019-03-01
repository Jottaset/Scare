using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;

namespace Scare
{
    public partial class MainPage : ContentPage
    {

        int cont = 0;

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            player.Load("tarzan.mp3");

            cont++;

            label_mensagem.Text = "Vc Clicou " + cont + " vezes";

            if (cont == 5)
            {
                player.Play();
                //label_mensagem.Text = "";
                img.Source = "https://systemmastery.files.wordpress.com/2014/07/tarzan-poster.jpg";
                cont = 0;
            }
                
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
