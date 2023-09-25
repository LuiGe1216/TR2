using Demo_MVVM.Data;
using Demo_MVVM.ViewM;
using Demo_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_MVVM.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            BindingContext = new LoginViewModel(new Database(
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "myDB.db3")),
            Navigation);
            //NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Register();
        }




        //private bool IsValidPassword(string password)
        //{
        // Definir la expresión regular para verificar la contraseña
        // Al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial
        //    string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@#$%^&+=!])(?=.{8,})";

        // Verificar si la contraseña coincide con el patrón
        //    return Regex.IsMatch(password, pattern);
        //}

    }
}