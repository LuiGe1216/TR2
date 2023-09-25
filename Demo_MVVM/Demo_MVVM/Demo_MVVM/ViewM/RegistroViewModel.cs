using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Demo_MVVM.Data;
using Demo_MVVM.Models;
using System.Threading.Tasks;
using Demo_MVVM.Views;
using Demo_MVVM.ViewM;
using Rg.Plugins.Popup.Services;

namespace Demo_MVVM.ViewM
{
    public class RegistroViewModel: BaseViewModel
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

        public ICommand RegistrarCommand { get; }

        private readonly Database _database;
        private readonly INavigation _navigation;

        public RegistroViewModel(Database databaseService, INavigation navigation)
        {
            _database = databaseService;
            _navigation = navigation;
            RegistrarCommand = new Command(Registrar);          
        }


        private async void Registrar()
        {
            // Validar que todos los campos se hayan completado
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Apellidos) ||
                string.IsNullOrWhiteSpace(Dni) || string.IsNullOrWhiteSpace(Edad) ||
                string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(NombreUsuario) ||
                string.IsNullOrWhiteSpace(Contrasena))
            {
                // Mostrar un mensaje de error si algún campo está vacío
                await App.Current.MainPage.DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return; // Salir del método si hay campos vacíos
            }

            // Validar la longitud del DNI
            if (Dni.Length != 8)
            {
                await App.Current.MainPage.DisplayAlert("Error", "El DNI debe tener exactamente 8 caracteres", "OK");
                return; // Salir del método si el DNI no tiene 8 caracteres
            }

            // Validar el formato del correo electrónico
            if (!IsValidEmail(Email))
            {
                await App.Current.MainPage.DisplayAlert("Error", "El correo electrónico no tiene un formato válido", "OK");
                return; // Salir del método si el correo electrónico no es válido
            }

            //Para validar contraseñas PT1
            if (!IsValidPassword(Contrasena))
            {
                await App.Current.MainPage.DisplayAlert("Error", "La contraseña debe tener al menos un carácter especial, una mayúscula, un número y ser mayor a 8 caracteres", "OK");
                return; // Salir del método si la contraseña no cumple con los requisitos
            }



            // Validar que todos los campos se hayan completado
            var user = new User
            {
                Name = Name,
                Apellidos = Apellidos,
                Dni = Dni,
                Edad = Edad,
                Email = Email,
                NombreUsuario = NombreUsuario,
                Contrasena = Contrasena

            };

            await _database.SaveUsuarioAsync(user);

            //await DisplayAlert("Éxito", "Registro exitoso", "OK");
            // Puedes agregar aquí la navegación a otra página o realizar otras acciones después de registrar al usuario.
            App.Current.MainPage = new Login();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email && email.Contains(".com");
            }
            catch
            {
                return false;
            }
        }

        //Para validar contraseña PT2
        private bool IsValidPassword(string password)
        {
            // Validar que la contraseña cumpla con los requisitos
            // Requisitos: al menos un carácter especial, una mayúscula, un número y longitud mayor a 8 caracteres

            if (string.IsNullOrWhiteSpace(password) || password.Length < 9)
            {
                return false;
            }

            // Verificar si contiene al menos un carácter especial, una mayúscula y un número
            bool hasSpecialChar = false;
            bool hasUpperCase = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
                else if (!char.IsLetterOrDigit(c))
                {
                    hasSpecialChar = true;
                }
            }

            return hasSpecialChar && hasUpperCase && hasNumber;
        }

    }
}
