using Plugin.Toast;
using Plugin.Toast.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleLoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (txtUserName.Text == String.Empty||txtUserName.Text==null)
            {
                CrossToastPopUp.Current.ShowToastWarning("Please enter username",ToastLength.Long);
                return;
            }
            if(String.IsNullOrEmpty(txtPassword.Text))
            {
                CrossToastPopUp.Current.ShowToastWarning("Please enter password");
                return;
            }
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if(userName=="faisal"&&password=="1234")
            {
                CrossToastPopUp.Current.ShowToastSuccess("Login successfull");
                //DisplayAlert("Success", "Login successfull", "ok");
            }
            else
            {
                CrossToastPopUp.Current.ShowToastError("Login failed");
                //CrossToastPopUp.Current.ShowCustomToast()
                //DisplayAlert("Failed", "Login failed", "ok");
            }
        }
    }
}