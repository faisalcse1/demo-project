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
    public partial class CarouselViewPage : ContentPage
    {
        public CarouselViewPage()
        {
            InitializeComponent();

            List<Image> images = new List<Image>()
            {
                new Image(){Title="Image 1",Url="https://cdn.pixabay.com/photo/2015/12/01/20/28/road-1072823_1280.jpg"},
                new Image(){Title="Image 2",Url="https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885_1280.jpg"},
                new Image(){Title="Image 3",Url="https://cdn.pixabay.com/photo/2018/05/17/09/18/away-3408119_1280.jpg"}
            };

            Carousel.ItemsSource = images;

            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
            {
                Carousel.Position = (Carousel.Position + 1) % images.Count;
                return true;
            }));
        }
    }
}