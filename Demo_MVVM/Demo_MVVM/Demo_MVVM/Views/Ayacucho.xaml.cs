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
    public partial class Ayacucho : ContentPage
    {
        public Ayacucho()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Ayacucho", Fecha = DateTime.Now, Precio = 70, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://denomades.s3.us-west-2.amazonaws.com/blog/wp-content/uploads/2020/09/13172228/arco-ayacucho.jpg"},
                new Imágenes(){url="https://denomades.s3.us-west-2.amazonaws.com/blog/wp-content/uploads/2019/07/18175455/61706726_155297135520362_4478797972603412384_n-1024x768.jpg"},
                new Imágenes(){url="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/36/73/5a/caption.jpg?w=300&h=300&s=1"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}