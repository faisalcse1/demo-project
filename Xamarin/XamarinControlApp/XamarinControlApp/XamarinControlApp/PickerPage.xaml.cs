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
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
            var countries = GetCountry();

            pickerCountry.ItemsSource = countries;
            //foreach(var country in countries)
            //{
            //    pickerCountry.Items.Add(country);
            //}
            
            //pickerCountry.Items.Add("USA");
            //pickerCountry.Items.Add("UK");
        }

        private List<Country> GetCountry()
        {
            return new List<Country>
            {
                new Country{Id=1,Name="Bangladesh"},
                new Country{Id=2,Name="USA"},
                new Country{Id=3,Name="UK"},
                new Country{Id=4,Name="India"}

               
            };
        }

        //private List<string>GetCountry()
        //{
        //    return new List<string>
        //    {
        //        "Bangladesh",
        //        "USA",
        //        "UK",
        //        "India"
        //    };
        //}

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            if(pickerCountry.SelectedIndex==-1)
            {
                DisplayAlert("Country", "Please select", "Ok");
                return;
            }
            Country country = pickerCountry.SelectedItem as Country;
            DisplayAlert("Country",country.Id+" - "+ country.Name, "Ok");
        }

        private void pickerCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerCountry.SelectedIndex == -1)
            {
                DisplayAlert("Country", "Please select", "Ok");
                return;
            }
            Country country = pickerCountry.SelectedItem as Country;
            DisplayAlert("Country", country.Id + " - " + country.Name, "Ok");
        }
    }
}