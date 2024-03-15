using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ListView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListView());
        }

        private async void CollectionView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CollectionView());
        }
        private async void DisplayAlert_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Details", "\r\nThe application I have developed is meticulously designed as an engaging platform tailored for individuals who harbor a genuine fondness for the endearing world of Sanrio characters. It offers an array of entertaining features intended to captivate and delight enthusiasts and admirers of all ages in a formal setting. ૮ • ﻌ - ა", "I UNDERSTSAND");
        }
    }
}
