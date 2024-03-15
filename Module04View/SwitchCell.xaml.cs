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
    public partial class SwitchCell : ContentPage
    {
        ObservableCollection<Sanrio> sanrios = new ObservableCollection<Sanrio>();
        public ObservableCollection<Sanrio> Sanrios { get { return sanrios; } }
        public SwitchCell()
        {
            InitializeComponent();

            SanrioView.ItemsSource = sanrios;

            sanrios.Add(new Sanrio { DisplayName = "Hello Kitty"});
            sanrios.Add(new Sanrio { DisplayName = "Cinnamoroll"});
            sanrios.Add(new Sanrio { DisplayName = "Kuromi"});
            sanrios.Add(new Sanrio { DisplayName = "My Melody"});
            sanrios.Add(new Sanrio { DisplayName = "Pochacco"});
        }

        private void displayMsg(object sender, ToggledEventArgs e)

        {
            bool isToggeledOn = e.Value;

            if (isToggeledOn)
            {
                DisplayAlert("Added to Favorites!", "Love it! ヅ ", "Ok");
            }

            else
            {
                DisplayAlert("Removed to Favorites!", "Who's your favorite? (っ◞‸◟ c)", "Ok");
            }
        }
    }
}