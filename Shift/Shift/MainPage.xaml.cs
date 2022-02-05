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
            bgcolor2.BackgroundColor = colors;
            ResetColor.TextColor = colors;
            Anime_1.BackgroundColor = colors;
            Anime_2.BackgroundColor = colors;
            Anime_3.BackgroundColor = colors;
            Anime_4.BackgroundColor = colors;
            AboutMe.TextColor = colors;
        }

        private void Reset(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var purple = Color.FromRgb(93, 29, 176); ;
            button.TextColor = purple;
            bgcolor.BackgroundColor = purple;
            bgcolor2.BackgroundColor = purple;
            ColorChange.TextColor = purple;
            Anime_1.BackgroundColor = purple;
            Anime_2.BackgroundColor = purple;
            Anime_3.BackgroundColor = purple;
            Anime_4.BackgroundColor = purple;
            AboutMe.TextColor = purple;
        }

        private async void SnkClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AttackOnTitan());
        }

        private async void AboutMeButton(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AboutMePage());
        }

        private async void BlackCloverClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BlackClover());
        }

        private async void OnePunchManClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new OnePunchMan());
        }
    }

}
