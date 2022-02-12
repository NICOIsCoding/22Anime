using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shift
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void DemonClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DemonSlayer());
        }


        private void ChangeColor(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Random rand = new Random();
            /*string[] colors1 = { "Red", "Green", "Blue" };
            int colors = int.Parse(colors1[rand.Next(colors1.Length)]);
            var colors2 = rand.Next(colors);
            //var converter = new ColorTypeConverter();
            //Color colors3 = Color.FromHex(colors);*/

            /*List<Color> colors2 = new List<Color>()
            {
                Color.Black,Color.White,Color.Red,Color.Blue
            };*/

            var colors = Color.FromRgb(rand.Next(256), rand.Next(256), rand.Next(256));

            button.TextColor = colors;
            bgcolor.BackgroundColor = colors;
            ResetColor.TextColor = colors;
            Anime_1.BackgroundColor = colors;
            Anime_2.BackgroundColor = colors;
            Anime_3.BackgroundColor = colors;
            Anime_4.BackgroundColor = colors;
            Anime_5.BackgroundColor = colors;
            Anime_6.BackgroundColor = colors;
            ChingChong.TextColor = Color.Black;
            ClickOnImage.TextColor = Color.Black;
            CallMe.TextColor = colors;
        }

        private void Reset(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var purple = Color.FromRgb(93, 29, 176);
            button.TextColor = purple;
            bgcolor.BackgroundColor = purple;
            ColorChange.TextColor = purple;
            Anime_1.BackgroundColor = purple;
            Anime_2.BackgroundColor = purple;
            Anime_3.BackgroundColor = purple;
            Anime_4.BackgroundColor = purple;
            Anime_5.BackgroundColor = purple;
            Anime_6.BackgroundColor = purple;
            ChingChong.TextColor = Color.Black;
            ClickOnImage.TextColor = Color.Black;
            CallMe.TextColor = purple;
        }

        private async void SnkClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AttackOnTitan());
        }

        private async void CallMeClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CallMe());
        }

        private async void BlackCloverClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BlackClover());
        }

        private async void OnePunchManClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new OnePunchMan());
        }

        private async void MyHeroAcademiaClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MyHeroAcademia());
        }

        private async void HunterClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HunterXHunter());
        }

        private void DarkOrWhite(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                var dark = Color.Black;
                var white = Color.White;
                ResetColor.TextColor = dark;
                bgcolor.BackgroundColor = dark;
                ColorChange.TextColor = dark;
                Anime_1.BackgroundColor = white;
                Anime_2.BackgroundColor = white;
                Anime_3.BackgroundColor = white;
                Anime_4.BackgroundColor = white;
                Anime_5.BackgroundColor = white;
                Anime_6.BackgroundColor = white;
                ClickOnImage.TextColor = white;
                ChingChong.TextColor = white;
                CallMe.TextColor = dark;
            }
            else
            {
                var purple = Color.FromRgb(93, 29, 176);
                ResetColor.TextColor = purple;
                bgcolor.BackgroundColor = purple;
                ColorChange.TextColor = purple;
                Anime_1.BackgroundColor = purple;
                Anime_2.BackgroundColor = purple;
                Anime_3.BackgroundColor = purple;
                Anime_4.BackgroundColor = purple;
                Anime_5.BackgroundColor = purple;
                Anime_6.BackgroundColor = purple;
                ClickOnImage.TextColor = Color.Black;
                ChingChong.TextColor = Color.Black;
                CallMe.TextColor = purple;
            }
            // ClickOnImage.Text = String.Format("Switch is now {0}", e.Value);
            /*if (button != null)
            {
                Anime_1.BackgroundColor = Color.Red;
            }
            else
            {
                Anime_1.BackgroundColor = Color.Blue;
            }*/
        }

    }
}
