﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shift
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutMePage : ContentPage
    {
        public AboutMePage()
        {
            InitializeComponent();
        }

        private void NamePress(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            NameText.TextColor = Color.Black;
        }

        private void AgePress(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AgeText.TextColor = Color.Black;
        }

        private void CountryPressed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            CountryText.TextColor = Color.Black;
        }

        public async void Button_Menu(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "Loading...";
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}