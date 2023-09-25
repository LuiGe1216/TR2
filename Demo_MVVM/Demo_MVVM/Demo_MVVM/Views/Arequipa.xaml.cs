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
    public partial class Arequipa : ContentPage
    {
        public Arequipa()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Arequipa", Fecha = DateTime.Now, Precio = 100, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://www.peruhop.com/wp-content/uploads/visitar-arequipa.jpg"},
                new Imágenes(){url="https://denomades.s3.us-west-2.amazonaws.com/blog/wp-content/uploads/2019/12/02173801/city-tour-arequipa-1024x683.jpg"},
                new Imágenes(){url="https://www.tuentrada.com.pe/wp-content/uploads/2021/12/Arequipa.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}