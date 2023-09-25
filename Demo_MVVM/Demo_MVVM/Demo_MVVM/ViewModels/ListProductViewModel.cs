using Demo_MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo_MVVM.ViewModels
{
    public class ListProductViewModel : BaseViewModel
    {
        private ObservableCollection<Product> _products;
        private ObservableCollection<Product> _filteredProducts;
        private string _searchTerm;

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { _products = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Product> FilteredProducts
        {
            get { return _filteredProducts; }
            set { _filteredProducts = value; OnPropertyChanged(); }
        }


        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                _searchTerm = value;
                OnPropertyChanged();
                FilterProducts();
            }
        }

        private Product _selectedProduct;

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; OnPropertyChanged(); }
        }

        public ICommand GoToDetailsCommand { private set; get; }

        public INavigation Navigation { get; set; }

        private readonly SQLiteConnection _database;

        public ListProductViewModel(INavigation navigation)
        {
            Navigation = navigation;
            GoToDetailsCommand = new Command<Type>(async (pageType) => await GoToDetails(pageType));
            _database = App.DatabaseConnection;

            LoadProductsFromDatabase();

            if (Products.Count == 0)
            {
                InsertInitialProducts();
            }

            // Initialize FilteredProducts with all products initially
            FilteredProducts = new ObservableCollection<Product>(Products);
        }

        private async Task LoadProductsFromDatabase()
        {
            var products = _database.Table<Product>().ToList();
            Products = new ObservableCollection<Product>(products);
        }

        private async Task GoToDetails(Type pageType)
        {
            if (SelectedProduct != null)
            {
                var page = (Page)Activator.CreateInstance(pageType);

                page.BindingContext = new ProductViewModel()
                {
                    IsAvailable = SelectedProduct.Reservar,
                    Destino = SelectedProduct.Destino,
                    Fecha = SelectedProduct.Fecha,
                    Precio = SelectedProduct.Precio,
                    ImagePath = _selectedProduct.ImagePath
                };

                //await Navigation.PushAsync(page);
            }
            //else
            //{
                  //await Application.Current.MainPage.DisplayAlert("Espera!", "Selecciona un destino antes de ver más detalles.", "Aceptar");
            //}
        }


        // Inserta los productos iniciales en la base de datos
        private void InsertInitialProducts()
        {
            var initialProducts = new List<Product>
            {

                new Product() { ID = 1, Destino = "Amazonas", Fecha = DateTime.Now, Precio = 50, Reservar = false, ImagePath = "Amazonas.jpg" },
                new Product() { ID = 2, Destino = "Ancash" ,Fecha = DateTime.Now, Precio = 60, Reservar = false, ImagePath = "Ancash.jpg" },
                new Product() { ID = 3, Destino = "Apurimac", Fecha = DateTime.Now, Precio = 50, Reservar = true , ImagePath = "Apurimac.jpg"},
                new Product() { ID = 4, Destino = "Arequipa", Fecha = DateTime.Now, Precio = 100, Reservar = true , ImagePath = "Arequipa.jpg"},
                new Product() { ID = 5, Destino = "Ayacucho", Fecha = DateTime.Now, Precio = 70, Reservar = false , ImagePath = "Ayacucho.jpg"},
                new Product() { ID = 6, Destino = "Cajamarca", Fecha = DateTime.Now, Precio = 60, Reservar = true , ImagePath = "Cajamarca.jpg"},
                new Product() { ID = 7, Destino = "Cusco", Fecha = DateTime.Now, Precio = 80, Reservar = true, ImagePath = "Cuzco.jpg" },
                new Product() { ID = 8, Destino = "Huancavelica", Fecha = DateTime.Now, Precio = 85, Reservar = false , ImagePath = "Huancavelica.jpg"},
                new Product() { ID = 9, Destino = "Huanuco", Fecha = DateTime.Now, Precio = 95, Reservar = true , ImagePath = "Huanuco.jpg"},
                new Product() { ID = 10, Destino = "Ica", Fecha = DateTime.Now, Precio = 90, Reservar = true , ImagePath = "Ica.jpg"},
                new Product() { ID = 11, Destino = "Junín", Fecha = DateTime.Now, Precio = 85, Reservar = false, ImagePath = "Junin.jpg" },
                new Product() { ID = 12, Destino = "La Libertad", Fecha = DateTime.Now, Precio = 45, Reservar = true, ImagePath = "Lalibertad.jpg" },
                new Product() { ID = 13, Destino = "Lambayeque", Fecha = DateTime.Now, Precio = 80, Reservar = true , ImagePath = "Lambayeque.jpg"},
                new Product() { ID = 14, Destino = "Lima", Fecha = DateTime.Now, Precio = 75, Reservar = false , ImagePath = "Limadepa.jpg"},
                new Product() { ID = 15, Destino = "Loreto", Fecha = DateTime.Now, Precio = 65, Reservar = false , ImagePath = "Loreto.jpg"},
                new Product() { ID = 16, Destino = "Madre de Dios", Fecha = DateTime.Now, Precio = 85, Reservar = false , ImagePath = "Madredios.jpg"},
                new Product() { ID = 17, Destino = "Moquegua", Fecha = DateTime.Now, Precio = 65, Reservar = false , ImagePath = "Moquegua.jpg"},
                new Product() { ID = 18, Destino = "Pasco", Fecha = DateTime.Now, Precio = 95, Reservar = false , ImagePath = "Pasco.jpg"},
                new Product() { ID = 19, Destino = "Piura", Fecha = DateTime.Now, Precio = 85, Reservar = false , ImagePath = "Piura.jpg"},
                new Product() { ID = 20, Destino = "Puno", Fecha = DateTime.Now, Precio = 65, Reservar = false , ImagePath = "Puno.jpg"},
                new Product() { ID = 21, Destino = "San Martín", Fecha = DateTime.Now, Precio = 75, Reservar = false , ImagePath = "Sanmartin.jpg"},
                new Product() { ID = 22, Destino = "Tacna", Fecha = DateTime.Now, Precio = 65, Reservar = false , ImagePath = "Tacna.jpg"},
                new Product() { ID = 23, Destino = "Tumbes", Fecha = DateTime.Now, Precio = 85, Reservar = false , ImagePath = "Tumbes.jpg"},
                new Product() { ID = 24, Destino = "Ucayali", Fecha = DateTime.Now, Precio = 105, Reservar = false , ImagePath = "Ucayali.jpg"}



            };

            foreach (var product in initialProducts)
            {
                _database.Insert(product);
                Products.Add(product);
            }
        }

        private void FilterProducts()
        {
            if (string.IsNullOrWhiteSpace(SearchTerm))
            {
                FilteredProducts = new ObservableCollection<Product>(Products);
            }
            else
            {
                var filtered = Products.Where(product => product.Destino.IndexOf(SearchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                 FilteredProducts = new ObservableCollection<Product>(filtered);
            }
        }
    }
}
        



