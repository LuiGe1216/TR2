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
    public partial class SanMartín : ContentPage
    {
        public SanMartín()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "San Martín", Fecha = DateTime.Now, Precio = 75, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://elcomercio.pe/resizer/4iFav49G2B_aC4-gIqWKaM97tdY=/980x0/smart/filters:format(jpeg):quality(75)/arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/W3X6JDR7LJELXEAHD6A4OJV5KY.jpg"},
                new Imágenes(){url="https://www.somosperu.org.pe/wp-content/uploads/2019/09/Gran-Pajaten-viajes-peru.jpg"},
                new Imágenes(){url="https://elcomercio.pe/resizer/--Xx1IzKNIqKiVCJI4mK8ioJ6h4=/1200x800/smart/filters:format(jpeg):quality(75)/cloudfront-us-east-1.images.arcpublishing.com/elcomercio/3XSPJJBCW5BLZOT6ND7FPCIPAM.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}