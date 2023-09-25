using Demo_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
        }

        private async void OnImageButtonTapped(object sender, EventArgs e)
        {
            // Navegar a Page2 al tocar la imagen como botón
            await Navigation.PushAsync(new Quienesomos());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Login();
        }

        async Task GetLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium, // Configura la precisión deseada
                    Timeout = TimeSpan.FromSeconds(10) // Opcional: establece un tiempo de espera
                });

                if (location != null)
                {
                    double latitude = location.Latitude;
                    double longitude = location.Longitude;

                    // Hacer algo con la ubicación (por ejemplo, mostrar en un mapa)
                }
            }
            catch (Exception ex)
            {
                // Manejar errores (por ejemplo, permisos denegados)
            }
        }
    }
}