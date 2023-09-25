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
    public partial class Contactos : ContentPage
    {
        public Contactos()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string numeroDeTelefono = "51955521569";
            string url = $"https://wa.me/{numeroDeTelefono}";
            await Launcher.OpenAsync(new Uri(url));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var message = new EmailMessage
            {
                Subject = "Consulta",
                Body = "",
                To = new List<string> { "hiosmy0912@gmail.com" }
            };

            await Email.ComposeAsync(message);
        }
    }
}
