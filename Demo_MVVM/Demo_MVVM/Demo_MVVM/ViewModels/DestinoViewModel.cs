using Demo_MVVM.Models;
using Demo_MVVM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo_MVVM.ViewModels
{
    public class DestinoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Product destinoSeleccionado;

        public Product DestinoSeleccionado
        {
            get { return destinoSeleccionado; }
            set
            {
                if (destinoSeleccionado != value)
                {
                    destinoSeleccionado = value;
                    OnPropertyChanged(nameof(DestinoSeleccionado));
                }
            }
        }

        public ICommand ReservarCommand { get; set; }

        public INavigation Navigation { get; set; }

        public DestinoViewModel()
        {
            ReservarCommand = new Command(Reservar);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Reservar()
        {
            if (DestinoSeleccionado != null)
            {
                // Navegar a la página de reserva y pasar el destino seleccionado
                Navigation.PushAsync(new ProductView(DestinoSeleccionado));
            }
        }
    }
}