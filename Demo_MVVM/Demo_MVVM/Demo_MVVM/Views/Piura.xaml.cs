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
    public partial class Piura : ContentPage
    {
        public Piura()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Piura", Fecha = DateTime.Now, Precio = 85, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://media-cdn.tripadvisor.com/media/photo-c/1280x250/0d/6c/1f/4c/vista-desde-el-parque.jpg"},
                new Imágenes(){url="https://blog.uber-cdn.com/cdn-cgi/image/width=2160,quality=80,onerror=redirect,format=auto/wp-content/uploads/2018/05/PE_Descubre-X-lugares-imperdibles-para-visitar-en-Piura.jpg"},
                new Imágenes(){url="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/14/b7/56/a4/nadando-con-tortugas.jpg?w=500&h=-1&s=1"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}