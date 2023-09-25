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
    public partial class Loreto : ContentPage
    {
        public Loreto()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Loreto", Fecha = DateTime.Now, Precio = 65, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://www.peru.travel/Contenido/General/Imagen/es/834/1.1/loreto-pacaya-samiria.jpg"},
                new Imágenes(){url="https://elcomercio.pe/resizer/A7CVI5h01g7y8tE77-SMMKlY9co=/580x330/smart/filters:format(jpeg):quality(75)/cloudfront-us-east-1.images.arcpublishing.com/elcomercio/YARFSGQV75HGPMMKXFORCFASSA.jpg"},
                new Imágenes(){url="https://villagrouploreto.s3.amazonaws.com/uploads/photo/image/2507/mision-de-san-javier-cerca-de-loreto-bcs.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}