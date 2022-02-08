using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shift
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void DarkTheme(object sender, EventArgs e)
        {

        }

        private void LightTheme(object sender, EventArgs e)
        {

        }

        private async void ButtonMenu(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Loading...";
            await Navigation.PopModalAsync();
        }

        /*private void entry_Completed(object sender, EventArgs e)
        {
            var text = ((Entry)sender).Text;
        }

        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }*/
        
        
    }
}