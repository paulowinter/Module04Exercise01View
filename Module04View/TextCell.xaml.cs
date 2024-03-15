using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextCell : ContentPage
    {
        ObservableCollection<Sanrio> sanrios = new ObservableCollection<Sanrio>();

        public ObservableCollection<Sanrio> Sanrios { get { return sanrios; } }
        public TextCell()
        {
            InitializeComponent();

            SanrioView.ItemsSource = sanrios;

            sanrios.Add(new Sanrio { DisplayName = "Hello Kitty ୨୧", Type = "is a Cat!" });
            sanrios.Add(new Sanrio { DisplayName = "Cinnamoroll ʚɞ", Type = "is a Dog!" });
            sanrios.Add(new Sanrio { DisplayName = "Kuromi ❤︎", Type = "is a Rabbit!" });
            sanrios.Add(new Sanrio { DisplayName = "My Melody ❀", Type = "is a White Rabbit!" });
            sanrios.Add(new Sanrio { DisplayName = "Pochacco •ﻌ•", Type = "is a White Dog!" });
        }

        private void DisplayAlert_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Details", "The company name, Sanrio, is derived from the Spanish words San Rio, which literally mean “Saint River” in English. San meaning “Saint” just like in the place names San Francisco and San Diego, and Rio meaning “River”, as in the names of riverside cities such as Rio de Janeiro and Rio Grande. So, the name Sanrio literally means “Saint River” or sacred river.", "OK");
        }
    }
}