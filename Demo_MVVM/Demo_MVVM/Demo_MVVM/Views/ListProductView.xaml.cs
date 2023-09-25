using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_MVVM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Demo_MVVM.ViewModels;

namespace Demo_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListProductView : ContentPage
    {
        public ListProductView()
        {
            InitializeComponent();

            BindingContext = new ViewModels.ListProductViewModel(Navigation);

            miListView.SelectionChanged += MiListView_SelectionChanged;
        }

        private Product destinoSeleccionado;
        private Product selectedProduct;


        private void MiListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                selectedProduct = (Product)e.CurrentSelection[0];

                // Obtén el objeto Product seleccionado
                destinoSeleccionado = selectedProduct;

                // Deselecciona el elemento para permitir que el evento se dispare nuevamente si se toca el mismo elemento
                miListView.SelectedItem = null;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (destinoSeleccionado != null)
            {
                // Ahora puedes utilizar productoSeleccionado para redirigir al usuario a una página de destino específica
                switch (destinoSeleccionado.Destino)
                {
                    case "Amazonas":
                        Navigation.PushAsync(new Amazonas());
                        break;

                    case "Ancash":
                        Navigation.PushAsync(new Ancash());
                        break;

                    case "Apurimac":
                        Navigation.PushAsync(new Apurimac());
                        break;

                    case "Arequipa":
                        Navigation.PushAsync(new Arequipa());
                        break;

                    case "Ayacucho":
                        Navigation.PushAsync(new Ayacucho());
                        break;

                    case "Cajamarca":
                        Navigation.PushAsync(new Cajamarca());
                        break;

                    case "Cusco":
                        Navigation.PushAsync(new Cusco());
                        break;

                    case "Huancavelica":
                        Navigation.PushAsync(new Huancavelica());
                        break;

                    case "Huanuco":
                        Navigation.PushAsync(new Huanuco());
                        break;

                    case "Ica":
                        Navigation.PushAsync(new Ica());
                        break;

                    case "Junín":
                        Navigation.PushAsync(new Junín());
                        break;

                    case "La Libertad":
                        Navigation.PushAsync(new LaLibertad());
                        break;

                    case "Lambayeque":
                        Navigation.PushAsync(new Lambayeque());
                        break;

                    case "Lima":
                        Navigation.PushAsync(new Lima());
                        break;

                    case "Loreto":
                        Navigation.PushAsync(new Loreto());
                        break;

                    case "Madre de Dios":
                        Navigation.PushAsync(new MadreDeDios());
                        break;

                    case "Moquegua":
                        Navigation.PushAsync(new Moquegua());
                        break;

                    case "Pasco":
                        Navigation.PushAsync(new Pasco());
                        break;

                    case "Piura":
                        Navigation.PushAsync(new Piura());
                        break;

                    case "Puno":
                        Navigation.PushAsync(new Puno());
                        break;

                    case "San Martín":
                        Navigation.PushAsync(new SanMartín());
                        break;

                    case "Tacna":
                        Navigation.PushAsync(new Tacna());
                        break;

                    case "Tumbes":
                        Navigation.PushAsync(new Tumbes());
                        break;

                    case "Ucayali":
                        Navigation.PushAsync(new Ucayali());
                        break;
                    // Agrega más casos para otros destinos
                    default:
                        DisplayAlert("Espera!", "Selecciona un destino antes de ver más detalles.", "Aceptar");
                        break;
                }

                // También puedes reiniciar la variable productoSeleccionado para que esté lista para la próxima selección
                destinoSeleccionado = null;
            }
            else
            {
                DisplayAlert("Espera!", "Selecciona un destino antes de ver más detalles.", "Aceptar");
            }
        }
    }
}