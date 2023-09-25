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
    public partial class Cajamarca : ContentPage
    {
        public Cajamarca()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Cajamarca", Fecha = DateTime.Now, Precio = 60, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://hotelmonthanas.com/wp-content/uploads/2022/07/plaza_de_cajamarca_hotel_.jpg"},
                new Imágenes(){url="https://peru.info/archivos/publicacion/126-imagen-190411372018.jpg"},
                new Imágenes(){url="https://cdn.www.gob.pe/uploads/document/file/436387/standard_Gobierno_Regional_-_Turismo_02.jpg"}
            };
            Carousel.ItemsSource = images;
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}