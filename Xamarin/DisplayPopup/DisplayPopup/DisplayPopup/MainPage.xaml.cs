using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DisplayPopup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonPopUp_Clicked(object sender, EventArgs e)
        {
          var response=await  DisplayAlert("Question", "Do you want to change color?","Yes","No");
            if(response)
            {
                //await DisplayAlert("Info", "Yes", "Cancel");
                this.BackgroundColor = Color.Green;
            }
            else
            {
                this.BackgroundColor = Color.White;
            }
            
        }
    }
}
