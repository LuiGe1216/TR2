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
    public partial class Cusco : ContentPage
    {
        public Cusco()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Cusco", Fecha = DateTime.Now, Precio = 80, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://www.inkanmilkyway.com/wp-content/uploads/2018/08/tourist-attractions-in-cusco-10.jpg"},
                new Imágenes(){url="https://blog.localadventures.mx/wp-content/uploads/2017/12/maras-moray-cusco-peru.jpg"},
                new Imágenes(){url="https://www.machupicchu-tours-peru.com/wp-content/uploads/2021/11/239195953_821898561841438_5002475087881208135_n.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ProductView());
        }
    }
}