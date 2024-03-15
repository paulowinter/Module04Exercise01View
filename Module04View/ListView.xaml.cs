using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {
        public ListView()
        {
            InitializeComponent();
        }

        private async void Textcell_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextCell());
        }

        private async void Entrycell_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryCell());
        }

        private async void Imagecell_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageCell());
        }

        private async void Switchcell_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwitchCell());
        }
    }
}