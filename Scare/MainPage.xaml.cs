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
            player.Load("sequencia_de_tiros.mp3");

            cont++;

            label_mensagem.Text = "Vc Clicou " + cont + " vezes";

            if (cont ==10)
            {
                player.Play();
                label_mensagem.Text = "Buhhhh";
                cont = 0;
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
