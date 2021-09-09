using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DisplayPopup
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ActionSheetPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
