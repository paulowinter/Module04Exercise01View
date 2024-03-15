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
    public partial class EntryCell : ContentPage
    {
        public EntryCell()
        {
            InitializeComponent();
        }
        void OnSubmitEntry(object sender, EventArgs e)
        {
            string entry1Text = fname.Text;
            string entry2Text = fav.Text;
            string entry3Text = thoughts.Text;
            DisplayAlert("Entries:",
                $"Firstname: {entry1Text}\n\nFavorite Character: {entry2Text}\n\nThoughts: {entry3Text}\n\nDo you want to submit?", "Ok", "Cancel");
        }
    }
}