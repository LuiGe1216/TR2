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
    public partial class MadreDeDios : ContentPage
    {
        public MadreDeDios()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Madre de Dios", Fecha = DateTime.Now, Precio = 85, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://portal.andina.pe/EDPfotografia3/Thumbnail/2022/07/05/000880898W.jpg"},
                new Imágenes(){url="https://www.aboutespanol.com/thmb/HoxU18hEOsSZx-bKVic7LyCMz2o=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/puerto_maldonado_viajeper-597b8b0a3df78cbb7a2514bd.jpg"},
                new Imágenes(){url="https://encolombia.com/wp-content/uploads/2012/12/Guacamayos-en-Tabopata-Madre-de-Dios-e1600904870105.jpeg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}