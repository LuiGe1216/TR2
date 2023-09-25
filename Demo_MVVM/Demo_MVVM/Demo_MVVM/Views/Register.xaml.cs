using Demo_MVVM.Data;
using Demo_MVVM.ViewM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();

            BindingContext = new RegistroViewModel(new Database(
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "myDB.db3")),
            Navigation);

        }
        protected override bool OnBackButtonPressed()
        {
            // Realiza la navegación de regreso a la vista de inicio de sesión (Login)
            App.Current.MainPage = new Login();

            return true; // Indica que has manejado el evento de la tecla de regreso
        }
    }
}