using Demo_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_MVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using SQLite;
using System.IO;
using Demo_MVVM.ViewM;

namespace Demo_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductView : ContentPage
    {
        public ProductView(Product product)
        {
            InitializeComponent();
            BindingContext = product;
        }

        private async void SendButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Enviado con éxito", "El mensaje se ha enviado correctamente.", "Aceptar");
            await Navigation.PopAsync();
        }
    }
}