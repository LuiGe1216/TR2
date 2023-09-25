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
    public partial class Ucayali : ContentPage
    {
        public Ucayali()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Ucayali", Fecha = DateTime.Now, Precio = 105, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://elcomercio.pe/resizer/hIBtVzvRjuCc8lD_qf67wQTjz8Q=/1200x675/smart/filters:format(jpeg):quality(75)/cloudfront-us-east-1.images.arcpublishing.com/elcomercio/FPMGQGLDFRBSZH7RW5P4CO3LTQ.jpg"},
                new Imágenes(){url="https://www.turismo-peru.com/wp-content/uploads/2018/02/parque-nacional-de-pucallpa.jpg"},
                new Imágenes(){url="https://denomades.s3.us-west-2.amazonaws.com/blog/wp-content/uploads/2020/03/13151045/catarata-regalia-1024x638.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}