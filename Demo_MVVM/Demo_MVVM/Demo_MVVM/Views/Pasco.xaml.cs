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
    public partial class Pasco : ContentPage
    {
        public Pasco()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Pasco", Fecha = DateTime.Now, Precio = 95, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://portal.andina.pe/EDPfotografia3/Thumbnail/2022/07/08/000881688W.jpg"},
                new Imágenes(){url="https://portal.andina.pe/EDPfotografia2/Thumbnail/2011/08/28/0000163831W.jpg"},
                new Imágenes(){url="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/09/19/9a/60/bosque-de-piedras-de.jpg?w=1200&h=1200&s=1"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            //Navigation.PushAsync(new ProductView());
        }
    }
}