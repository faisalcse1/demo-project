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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            //imguser.Source = ImageSource.FromFile("pp.png");
            //imguser.Source = ImageSource.FromResource("XamarinControlApp.MDFAISAL.png");
        }
    }
}