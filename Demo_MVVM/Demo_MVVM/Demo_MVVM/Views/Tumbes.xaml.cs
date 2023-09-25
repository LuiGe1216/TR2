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
    public partial class Tumbes : ContentPage
    {
        public Tumbes()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Tumbes", Fecha = DateTime.Now, Precio = 85, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://www.munitumbes.gob.pe/muni2019/wp-content/uploads/2019/09/image.png"},
                new Imágenes(){url="https://blog.redbus.pe/wp-content/uploads/2021/03/punta-sal-To-Peru.jpg"},
                new Imágenes(){url="https://www.notiviajeros.com/wp-content/uploads/2016/08/ballenas-tumbes-turismo.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}