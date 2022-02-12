using System;
using Xamarin.Forms;

namespace Shift
{
    public partial class ContentPageEx : ContentPage
    {
        public ContentPageEx()
        {
        }

        private async void Button_Menu(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Loading...";
            await Navigation.PopModalAsync();
        }

    }
}