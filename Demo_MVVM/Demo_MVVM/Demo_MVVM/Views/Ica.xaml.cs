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
    public partial class Ica : ContentPage
    {
        public Ica()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Ica", Fecha = DateTime.Now, Precio = 90, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://airbrag.com/wp-content/uploads/2023/01/interna-5-sitios-turisticos-de-ica-2.jpg"},
                new Imágenes(){url="https://airbrag.com/wp-content/uploads/2023/01/portada-5-sitios-turisticos-de-ica.jpg"},
                new Imágenes(){url="https://perutravelexpress.com/wp-content/uploads/2020/11/Ica-Huacachina.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}