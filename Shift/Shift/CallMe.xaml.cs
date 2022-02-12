using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shift
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallMe : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public CallMe()
        {
            InitializeComponent();
            BindingContext = this;
            // DiscordAnimation();
        }

        private void ButtonMenu(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Loading...";
            // await Navigation.PopModalAsync();
        }

        /*private void DiscordAnimation()
        {
            // DiscordIcon.TranslateTo(2, 100);
            DiscordIcon.TranslateTo(0, DiscordIcon.TranslationY - 100, 2000);
            // System.Threading.Thread.Sleep(200);
            DiscordAnimation();
        }*/
    }
}