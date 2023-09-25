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
    public partial class Amazonas : ContentPage
    {
        public Amazonas()
        {
            InitializeComponent();
            BindingContext = new DestinoViewModel
            {
                DestinoSeleccionado = new Product { Destino = "Amazonas", Fecha = DateTime.Now, Precio = 50, Reservar = false },
                Navigation = Navigation
            };

            List<Imágenes> images = new List<Imágenes>()
            {
                new Imágenes(){url="https://www.fundacionaquae.org/wp-content/uploads/2019/07/rio-amazonas.jpg"},
                new Imágenes(){url="https://fotografias.larazon.es/clipping/cmsimages01/2022/08/14/B83143A1-02B4-4874-B656-CF0E2F9FAD06/69.jpg?crop=4551,2560,x0,y236&width=1280&height=720&optimize=low&format=jpg"},
                new Imágenes(){url="https://t2.ea.ltmcdn.com/es/posts/1/4/3/los_11_animales_mas_peligrosos_del_amazonas_23341_orig.jpg"}
            };
            Carousel.ItemsSource = images;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
          //Navigation.PushAsync(new ProductView());
        }
    }
}