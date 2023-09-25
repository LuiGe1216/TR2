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
    public partial class Junín : ContentPage
    {
        public Junín()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Junín", Fecha = DateTime.Now, Precio = 85, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://elcomercio.pe/resizer/wLsIUq0nsGFFmeG0l4JeFJpgpt0=/1200x675/smart/filters:format(jpeg):quality(75)/arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/POAA4BN2CFGOBMOU4RXOCPA4TQ.jpg"},
                new Imágenes(){url="https://www.turismo-peru.com/wp-content/uploads/2022/09/Las-agujas-de-Arenisca-Torre.jpg"},
                new Imágenes(){url="https://portal.andina.pe/EDPfotografia3/Thumbnail/2017/11/12/000462763W.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}