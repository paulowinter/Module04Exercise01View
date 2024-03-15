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
    public partial class CollectionView : ContentPage
    {
        ObservableCollection<Sanrio> sanrios;
        public CollectionView()
        {
            InitializeComponent();
            sanrios = new ObservableCollection<Sanrio> 
            {  
                new Sanrio
                {
                    DisplayName = "Badtz-Maru ✟", Type = "is a little penguin!", Image = "https://seeklogo.com/images/B/Badtz_Maru-logo-2ED5481A5F-seeklogo.com.png"
                },
                new Sanrio
                {
                    DisplayName = "Keroppi ☘︎", Type = "is a Frog!", Image = "https://mystickermania.com/cdn/stickers/noob-pack/sanrio-keroppi-winks-512x512.png"
                },
                new Sanrio
                {
                    DisplayName = "Pompompurin •ﻌ•", Type = "is a Golden Retriever!", Image = "https://i.pinimg.com/originals/d9/43/d8/d943d8cf079bb106a04db3363479b337.png"
                },
                new Sanrio
                {
                    DisplayName = "Gudetama ❀", Type = "is an Egg!", Image = "https://www.pngmart.com/files/23/Gudetama-Download-PNG-Image.png"
                },
                new Sanrio
                {
                    DisplayName = "Little Twin Stars ˗ˏˋ ★ ˎˊ˗", Type = "are Angels!", Image = "https://i.pinimg.com/originals/d6/a5/f0/d6a5f03d9ba70dd5d7ad107864b3483d.png"
                },
            };
            Sanrios.ItemsSource = sanrios;
        }

        private void Sanrio_Selection(object sender, SelectionChangedEventArgs e)
        {
            var itemSelected = e.CurrentSelection[0] as Sanrio;
            if (itemSelected != null)
                DisplayAlert($"{itemSelected.DisplayName}", $"{itemSelected.Type}", "OK");
        }
    }
}