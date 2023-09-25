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
    public partial class Huancavelica : ContentPage
    {
        public Huancavelica()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Huancavelica", Fecha = DateTime.Now, Precio = 85, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://blog.redbus.pe/wp-content/uploads/2018/08/Huancavelica-Turismoi.jpg"},
                new Imágenes(){url="https://blog.redbus.pe/wp-content/uploads/2021/07/Iglesia-Central-de-Huancavelica.jpg"},
                new Imágenes(){url="https://mochileaperu.com/wp-content/uploads/2020/03/tresboashuancavelica-800x445-1-696x387.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}