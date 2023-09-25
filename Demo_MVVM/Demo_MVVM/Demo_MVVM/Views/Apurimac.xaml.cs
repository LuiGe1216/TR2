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
    public partial class Apurimac : ContentPage
    {
        public Apurimac()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Apurimac", Fecha = DateTime.Now, Precio = 50, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/15/19/4d/d1/apurimac-expedition.jpg?w=1200&h=-1&s=1"},
                new Imágenes(){url="https://www.facetaslarevista.com/wp-content/uploads/2021/02/01-lugares-turisticos-de-Apurimac.jpg"},
                new Imágenes(){url="https://i.ytimg.com/vi/md9LOd9qOdc/maxresdefault.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}