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
    public partial class Puno : ContentPage
    {
        public Puno()
        {
            InitializeComponent(); BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Puno", Fecha = DateTime.Now, Precio = 65, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://denomades.s3.us-west-2.amazonaws.com/blog/wp-content/uploads/2018/10/25200758/download-171.jpg"},
                new Imágenes(){url="https://denomades.s3.us-west-2.amazonaws.com/blog/wp-content/uploads/2018/10/25195527/download-42.jpg"},
                new Imágenes(){url="https://elcomercio.pe/resizer/2Q8Y9ruqf1bI3pcQ3isYRN6ytJQ=/980x0/smart/filters:format(jpeg):quality(75)/arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/ZUCFPOQHKBGUFO2ZZSBHCGUZKQ.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}