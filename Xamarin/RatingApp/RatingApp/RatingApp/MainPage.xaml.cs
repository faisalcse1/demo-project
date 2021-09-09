using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RatingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            int rating = Rating.SelectedStarValue;
            DisplayAlert("Rating Value", rating.ToString(), "Ok");
        }
    }
}
