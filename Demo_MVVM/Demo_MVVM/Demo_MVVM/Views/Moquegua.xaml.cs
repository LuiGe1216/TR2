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
    public partial class Moquegua : ContentPage
    {
        public Moquegua()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Moquegua", Fecha = DateTime.Now, Precio = 65, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://www.ytuqueplanes.com/imagenes//fotos/novedades/b-lugares-turisticos-de-moquegua.png"},
                new Imágenes(){url="https://masdestinos.com/wp-content/uploads/iglesia-de-santo-domingo-moquegua.jpg"},
                new Imágenes(){url="https://www.ytuqueplanes.com/imagenes/fotos/regiones/RC-BANNER-INT-Moquegua.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}