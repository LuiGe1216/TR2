using Demo_MVVM.Models;
using Demo_MVVM.Views;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_MVVM
{
    public partial class App : Application
    {
        public static SQLiteConnection DatabaseConnection { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());

            String _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");


            // Crear una conexión a la base de datos
            DatabaseConnection = new SQLiteConnection(_dbPath);

            // Crear la tabla Usuario si no existe
            DatabaseConnection.CreateTable<Product>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
