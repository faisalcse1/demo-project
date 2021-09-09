using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListPageExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {
        public ObservableCollection<Product> Products { get; set; }
        public ProductListPage()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>
            {
                new Product{Name="Sprite",Price=20},
                new Product{Name="Cocacola",Price=20},
                new Product{Name="Pran Up",Price=18},
                new Product{Name="Fizz Up",Price=20},
            };

            ProductListView.ItemsSource = Products;
        }

        private void ProductListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item==null)
            {
                return;
            }
            ((ListView)sender).SelectedItem = null;
            Navigation.PushModalAsync(new ProductDetailsPage(e.Item as Product));
            
        }
    }
}