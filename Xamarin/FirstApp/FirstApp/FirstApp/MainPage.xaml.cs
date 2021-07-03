using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {

        //Label labelInfo = null;
        //Entry Name = null;
        //Button ShowButton = null;
        //Label lblName = null;
        public MainPage()
        {
            InitializeComponent();

            //labelInfo = new Label() { Text = "Name" };
            //Name = new Entry() { Placeholder = "Enter your name" };
            //ShowButton = new Button() { Text = "Show", TextColor = Color.White, BackgroundColor = Color.Blue };
            //ShowButton.Clicked += ShowButton_Clicked;
            //lblName = new Label() { HorizontalOptions=LayoutOptions.Center,
            //VerticalOptions=LayoutOptions.Center};

            //this.Content = new StackLayout
            //{
            //    Children =
            //    {
            //        labelInfo,
            //        Name,
            //        ShowButton,
            //        lblName
            //    }
            //};

            //LabelInfo.Text = "Hello world";           
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            string name = Name.Text;
            Name.Text = String.Empty;
            lblName.Text = name;

        }
    }
}
