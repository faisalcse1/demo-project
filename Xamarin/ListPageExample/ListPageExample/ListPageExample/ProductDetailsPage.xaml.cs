using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListPageExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailsPage : ContentPage
    {
        public ProductDetailsPage(Product product)
        {
            InitializeComponent();
            LabelName.Text = product.Name;
            LabelPrice.Text = product.Price.ToString(); ;
        }
    }
}