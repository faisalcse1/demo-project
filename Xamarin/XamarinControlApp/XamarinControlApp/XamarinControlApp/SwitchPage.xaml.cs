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
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
            
        }

        private void BtnShow_Clicked(object sender, EventArgs e)
        {
            //bool isCheck = Switch.IsToggled;
            //bool isCheck = CheckBox.IsChecked;            
            //DisplayAlert("Message", isCheck.ToString(), "Ok");
            string programminglanguage = "";
            if(RadioBtnCsharp.IsChecked)
            {
                programminglanguage = RadioBtnCsharp.Value.ToString();
            }
            if (RadioBtnJava.IsChecked)
            {
                programminglanguage = RadioBtnJava.Value.ToString();
            }
                DisplayAlert("Message", programminglanguage, "Ok");
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            bool isCheck = Switch.IsToggled;
            DisplayAlert("Message", isCheck.ToString(), "Ok");
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            bool isCheck = CheckBox.IsChecked;
            DisplayAlert("Message", isCheck.ToString(), "Ok");
        }
    }
}