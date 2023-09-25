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
    public partial class Tacna : ContentPage
    {
        public Tacna()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Tacna", Fecha = DateTime.Now, Precio = 65, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://blog.redbus.pe/wp-content/uploads/2018/08/Tacna-Peru-Alto-de-la-Alianza.jpg"},
                new Imágenes(){url="https://www.ytuqueplanes.com/imagenes/fotos/novedades/lugares-turisticos-tacna-geiseres.jpg"},
                new Imágenes(){url="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/07/83/64/2e/paseo-civico.jpg?w=500&h=400&s=1"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}