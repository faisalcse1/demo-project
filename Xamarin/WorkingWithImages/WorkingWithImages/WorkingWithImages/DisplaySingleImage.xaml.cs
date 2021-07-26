using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithImages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplaySingleImage : ContentPage
    {
        public DisplaySingleImage(ImageSource imageSource)
        {
            InitializeComponent();
            imgUser.Source = imageSource;
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}