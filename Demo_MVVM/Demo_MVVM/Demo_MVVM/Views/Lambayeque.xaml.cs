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
    public partial class Lambayeque : ContentPage
    {
        public Lambayeque()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Lambayeque", Fecha = DateTime.Now, Precio = 80, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://blog.redbus.pe/wp-content/uploads/2017/11/catedral.jpeg"},
                new Imágenes(){url="https://elcomercio.pe/resizer/vB2MmhqxGx8rZqCnLrZ0WjTg9N0=/1200x1200/smart/filters:format(jpeg):quality(75)/arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/Z3BG22B7E5AJPMT2KDLY66G4YQ.jpg"},
                new Imágenes(){url="https://seturismo.pe/wp-content/uploads/2018/08/Museo-Se%C3%B1or-de-Sipan.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}