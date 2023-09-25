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
    public partial class Reservaciones : ContentPage
    {
        public Reservaciones(string nombreLugar, string direccionLugar)
        {
            InitializeComponent();

            NombreLugarLabel.Text = nombreLugar;
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Aquí puedes acceder a los valores ingresados en los campos
            string costo = CostoEntry.Text;
            string nombres = NombresEntry.Text;

            // Realiza las operaciones necesarias con estos datos
            // Por ejemplo, puedes enviarlos a un servidor para procesar la reserva

            // Luego, puedes navegar de regreso a la página anterior o realizar otra acción
            Navigation.PopAsync(); // Esto navegará de regreso a la página principal
        }
    }
}