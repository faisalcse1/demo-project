using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinControlApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebVIewPage : ContentPage
    {
        public WebVIewPage()
        {
            InitializeComponent();
            //BrowserLink.Source = "https://www.google.com/";
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(WebLink.Text))
            {
                DisplayAlert("Warning", "Please enter weblink", "ok");
                return;
            }
            string url ="https://"+ WebLink.Text;
            BrowserLink.Source = url;
        }
    }
}