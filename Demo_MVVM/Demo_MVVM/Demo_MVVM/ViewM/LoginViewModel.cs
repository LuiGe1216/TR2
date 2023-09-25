using Demo_MVVM.Data;
using Demo_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Demo_MVVM;
using Demo_MVVM.ViewModels;

namespace Demo_MVVM.ViewM
{
    public class LoginViewModel:BaseViewModel
    {
        private string _name;
        private string _apellidos;
        private string _dni;
        private string _edad;
        private string _email;
        private string _nombreusuario;
        private string _contrasena;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Apellidos
        {
            get => _apellidos;
            set => SetProperty(ref _apellidos, value);
        }

        public string Dni
        {
            get => _dni;
            set => SetProperty(ref _dni, value);
        }

        public string Edad
        {
            get => _edad;
            set => SetProperty(ref _edad, value);
        }

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public string NombreUsuario
        {
            get => _nombreusuario;
            set => SetProperty(ref _nombreusuario, value);
        }

        public string Contrasena
        {
            get => _contrasena;
            set => SetProperty(ref _contrasena, value);
        }

        private bool _isLoggedIn;

        public bool IsLoggedIn
        {
            get => _isLoggedIn;
            set => SetProperty(ref _isLoggedIn, value);
        }

        public ICommand IniciarSesionCommand { get; }
        

        private INavigation _navigation;

        private readonly Database _database;

        public LoginViewModel(Database databaseService, INavigation navigation)
        {
            _database = databaseService;
            _navigation = navigation;
            IniciarSesionCommand = new Command(IniciarSesion);
            
            
        }


        private async void IniciarSesion()
        {
            if (string.IsNullOrWhiteSpace(NombreUsuario) || string.IsNullOrWhiteSpace(Contrasena))
            {
                // Mostrar un mensaje de error si alguno de los campos está vacío
                await App.Current.MainPage.DisplayAlert("Error", "Usuario y contraseña son obligatorios", "OK");
                return; // Salir del método si hay campos vacíos
            }

            // Aquí debes implementar la lógica para verificar el inicio de sesión.
            // Puedes consultar la base de datos SQLite para encontrar el usuario correspondiente.

            var usuarios = await _database.GetUsuariosAsync();
            var usuario = usuarios.Find(u => u.NombreUsuario == NombreUsuario && u.Contrasena == Contrasena);
            

            if (usuario != null)
            {
                // El inicio de sesión fue exitoso. Puedes navegar a la página principal o realizar otras acciones.
                IsLoggedIn = true;
                App.Current.MainPage = new AppShell();
            }
            else
            {
                // El inicio de sesión falló. Puedes mostrar un mensaje de error al usuario.
                App.Current.MainPage = new Login();
            }
        }
       
    }
}
