using Demo_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Demo_MVVM.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {

        private Product selectProduct;

        public Product SelectProduct
        {
            get { return selectProduct; }
            set
            {
                if (selectProduct != value)
                {
                    selectProduct = value;
                    OnPropertyChanged(nameof(SelectProduct));
                }
            }
        }

        private string _destino;

        public string Destino
        {
            get { return _destino; }
            set { _destino= value; OnPropertyChanged(); }
        }


        private double _precio;

        private DateTime _fecha;
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; OnPropertyChanged(); }
        }

        public double Precio
        {
            get { return _precio; }
            set { _precio= value; OnPropertyChanged(); }
        }

        private bool _isAvailable;
        internal string ImagePath;


        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; OnPropertyChanged(); }
        }

        private int _numeroPasajeros;

        public int NumeroPasajeros
        {
            get { return _numeroPasajeros; }
            set
            {
                if (_numeroPasajeros != value)
                {
                    _numeroPasajeros = value;
                    OnPropertyChanged(nameof(NumeroPasajeros));
                }
            }
        }

        public ICommand ClearCommand { private set; get; }
        public ICommand SendEmailCommand { private set; get; }

        public ProductViewModel()
        {
            ClearCommand = new Command(() => Clear());
            SendEmailCommand = new Command(async () => await SendEmail());
        }


        void Clear()
        {
            Destino = string.Empty;
            Precio = 0;
            IsAvailable = false;
        }


        async Task SendEmail()
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = "Nueva reserva!",
                    Body = $"Nombre del destino: {Destino}\nFecha: {Fecha}\nPrecio: {Precio:N2}\nAvailability? {(IsAvailable ? "Yes" : "No")}",
                    To = new List<string> { "luis@luisbeltran.mx" }
                };

                await Email.ComposeAsync(message);
            }
            catch (Exception)
            {

            }
        }
    }
}


   
