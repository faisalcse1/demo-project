using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithImages
{

    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension:IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if(Source==null)
            {
                return null;
            }

            var imageResource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imageResource;
        }
    }
}
