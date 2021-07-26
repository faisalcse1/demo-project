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
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();
            
        }    
        

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            DateTime date = datePicker.Date;
            var time = timePicker.Time;

            string datetime = "Date: " + date.ToString("d") + " time is: " + time.ToString();
            lblResult.Text = datetime;
        }

        
    }
}