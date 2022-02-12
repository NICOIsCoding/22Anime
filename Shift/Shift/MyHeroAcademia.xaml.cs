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
    public partial class MyHeroAcademia : ContentPage
    {
        public MyHeroAcademia()
        {
            InitializeComponent();
        }
        private async void Button_Menu(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Loading...";
            await Navigation.PopModalAsync();
        }
    }
}