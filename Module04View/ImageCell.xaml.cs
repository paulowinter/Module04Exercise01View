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

    public partial class ImageCell : ContentPage
    {
        ObservableCollection<Sanrio> sanrios = new ObservableCollection<Sanrio>();

        public ObservableCollection<Sanrio> Sanrios {  get { return sanrios; } }
        public ImageCell()
        {
            InitializeComponent();

            SanrioView.ItemsSource = sanrios;

            sanrios.Add(new Sanrio { DisplayName = "Hello Kitty ୨୧", Type = "is a Cat!", Image = "https://www.pngall.com/wp-content/uploads/13/Hello-Kitty-PNG-Clipart.png" });
            sanrios.Add(new Sanrio { DisplayName = "Cinnamoroll ʚɞ", Type = "is a Dog!", Image = "https://cdn.sanriowiki.com/2/23/Cinnamoroll.png" });
            sanrios.Add(new Sanrio { DisplayName = "Kuromi ❤︎", Type = "is a Rabbit!", Image = "https://seeklogo.com/images/K/kuromi-logo-68C9041203-seeklogo.com.png" });
            sanrios.Add(new Sanrio { DisplayName = "My Melody ❀", Type = "is a White Rabbit!", Image = "https://cartoon-clipart.co/amp/images/my-melody.png" });
            sanrios.Add(new Sanrio { DisplayName = "Pochacco •ﻌ•", Type = "is a White Dog!", Image = "https://static.wikia.nocookie.net/hellokitty/images/c/c2/Sanrio_Characters_Pochacco_Image005.png/revision/latest?cb=20170406171435" });
        }

        private void DisplayAlert_Clicked(object sender, EventArgs e)
        {
             DisplayAlert ("Details", "You have been alerted", "OK");
        }
    }
}