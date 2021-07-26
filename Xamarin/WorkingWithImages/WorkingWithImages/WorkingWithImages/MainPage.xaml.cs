using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkingWithImages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            imgUser.Source = ImageSource.FromUri(new Uri("https://4.bp.blogspot.com/-3SVaoS-36HU/YBEzfuyiDuI/AAAAAAAAAJw/fWn6jqqRIQ480cJSu1dxpw9s0z0xESEhwCK4BGAYYCw/s1600/Asp%2BDot%2BNet%2BExplorer.jpg"));
            imgLocalResource.Source = ImageSource.FromFile("aspdotnetexplorer.png");
        }
    }
}
