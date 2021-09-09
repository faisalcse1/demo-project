using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private decimal firstNumner;
        private string operatorName;
        private bool isOperatorClicked;
        
        private void BtnCommon_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if(LblResult.Text=="0"||isOperatorClicked)
            {
                isOperatorClicked = false;
                LblResult.Text = button.Text;
            }
            else
            {
                LblResult.Text += button.Text;
            }
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            LblResult.Text = "0";
            isOperatorClicked = false;
            firstNumner = 0;
        }

        private void BtnX_Clicked(object sender, EventArgs e)
        {
            string number = LblResult.Text;
            if(number!="0")
            {
                number = number.Remove(number.Length - 1, 1);
                if(string.IsNullOrEmpty(number))
                {
                    LblResult.Text = "0";                    
                }
                else
                {
                    LblResult.Text = number;
                }
            }
        }

        private void BtnCommonOperation_Clicked(object sender,EventArgs e)
        {
            var button = sender as Button;
            isOperatorClicked = true;
            operatorName = button.Text;
            firstNumner = Convert.ToDecimal(LblResult.Text);
        }

        private async void BtnPercentage_Clicked(object sender, EventArgs e)
        {
            try
            {
              string number= LblResult.Text;
                if(number!="0")
                {
                    decimal percentValue = Convert.ToDecimal(number);
                    string result = (percentValue / 100).ToString("0.##");
                    LblResult.Text = result;
                }
            }
            catch(Exception ex)
            {
               await DisplayAlert("Error",ex.Message,"Ok");
            }
        }

        private void BtnEqual_Clicked(object sender, EventArgs e)
        {
            try
            {
                decimal secondNumber =Convert.ToDecimal(LblResult.Text);
                string finalResult = Calculate(firstNumner, secondNumber).ToString("0.##");
                LblResult.Text = finalResult;
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        public decimal Calculate(decimal firstNumber,decimal secondNumber)
        {
            decimal result = 0;
            if(operatorName=="+")
            {
                result= firstNumber + secondNumber;
            }
            else if (operatorName == "-")
            {
                result= firstNumber - secondNumber;
            }
            else if (operatorName == "*")
            {
                result= firstNumber * secondNumber;
            }
            else if (operatorName == "/")
            {
                result= firstNumber / secondNumber;
            }
            return result;
        }
    }
}
