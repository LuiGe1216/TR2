using Demo_MVVM.Models;
using Demo_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ancash : ContentPage
    {
        public Ancash()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Ancash", Fecha = DateTime.Now, Precio = 60, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1a/69/a8/12/caption.jpg?w=1200&h=-1&s=1"},
                new Imágenes(){url="https://elcomercio.pe/resizer/-0kDfxzGitXIOCHXtP69gVS0tlU=/620x0/smart/filters:format(jpeg):quality(75)/cloudfront-us-east-1.images.arcpublishing.com/elcomercio/YIWCB4E7LNG2FF4EZ4KO4SKFBM.jpg"},
                new Imágenes(){url="https://catedraunesco.usmp.edu.pe/wp-content/uploads/2018/08/11-chavin.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}