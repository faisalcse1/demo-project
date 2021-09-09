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
    public partial class ActionSheetPage : ContentPage
    {
        public ActionSheetPage()
        {
            InitializeComponent();
        }

        private async void ActionSheet_Clicked(object sender, EventArgs e)
        {
          var click=await  DisplayActionSheet("Image option", "Cancel","", "Delete", "Share", "Save");
            if(click== "Delete")
            {
                LabelMessage.Text = "Image Deleted";
            }
            else if(click== "Share")
            {
                LabelMessage.Text = "Image Shared";
            }
            else if (click == "Save")
            {
                LabelMessage.Text = "Image Downloaded";
            }
            else
            {
                LabelMessage.Text = "Exit";
            }
        }
    }
}