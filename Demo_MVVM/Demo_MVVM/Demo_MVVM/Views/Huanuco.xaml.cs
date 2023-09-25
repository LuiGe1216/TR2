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
    public partial class Huanuco : ContentPage
    {
        public Huanuco()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Huanuco", Fecha = DateTime.Now, Precio = 95, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://portal.andina.pe/EDPfotografia3/Thumbnail/2016/06/22/000362717W.jpg"},
                new Imágenes(){url="https://huanuco.info/uploads/medium/cordillera-huayhuash.jpg"},
                new Imágenes(){url="https://www.aboutespanol.com/thmb/8FhE9GnAG953iV8kbqOwXMtBy4E=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/complejo-arqueologico-de-huanuco-56a2a6e93df78cf772787180.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}