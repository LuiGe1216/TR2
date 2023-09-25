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
    public partial class LaLibertad : ContentPage
    {
        public LaLibertad()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "La Libertad", Fecha = DateTime.Now, Precio = 45, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://blog.redbus.pe/wp-content/uploads/2021/09/shutterstock_445221361-scaled-e1632435561682.jpg"},
                new Imágenes(){url="https://blog.redbus.pe/wp-content/uploads/2021/09/shutterstock_672286114-scaled.jpg"},
                new Imágenes(){url="https://blog.redbus.pe/wp-content/uploads/2021/09/shutterstock_445221370-scaled.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}