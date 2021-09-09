using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DisplayPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPromptPage : ContentPage
    {
        public DisplayPromptPage()
        {
            InitializeComponent();
        }

        private async void ButtonQuestion_Clicked(object sender, EventArgs e)
        {
           var response= await DisplayPromptAsync("Question", "What is your name?","Yes","No","type your name");
           if(response!=null)
            {
                LabelResult.Text = response;
            }
        }
    }
}