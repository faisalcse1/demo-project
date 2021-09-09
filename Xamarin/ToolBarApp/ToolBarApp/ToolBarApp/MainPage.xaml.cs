using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ToolBarApp
{
    public partial class MainPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void AddToolBarItem_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new AddPage());
        }
    }
}
