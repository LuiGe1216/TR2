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
    public partial class Lima : ContentPage
    {
        public Lima()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Lima", Fecha = DateTime.Now, Precio = 75, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://denomades.s3.us-west-2.amazonaws.com/blog/wp-content/uploads/2020/08/30162219/lima-peru-shutterstock_1047718252.jpg"},
                new Imágenes(){url="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/16/1b/a9/28/photo0jpg.jpg?w=500&h=-1&s=1"},
                new Imágenes(){url="https://www.limatourperu.com/wp-content/uploads/parque-del-amor-lima.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}