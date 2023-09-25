using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace Demo_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        private Pin selectedPin;

        public MapPage()
        {
            InitializeComponent();

            Pin MiUbi1 = new Pin()
            {
                Type = PinType.Place,
                Label = "Amazonas",
                Address = "Plaza de Chachapoyas, Chachapoyas",
                Position = new Position(-6.229240654553539, -77.87239831784258),
                Tag = "id_miubi1",
            };
            MiUbi1.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Green);

            Pin MiUbi2 = new Pin()
            {
                Type = PinType.Place,
                Label = "Loreto",
                Address = "Plaza Bolognesi, Iquitos",
                Position = new Position(-3.764726745908028, -73.2566791303743),
                Tag = "id_miubi2",
            };
            MiUbi2.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Green);

            Pin MiUbi3 = new Pin()
            {
                Type = PinType.Place,
                Label = "Madre de Dios",
                Address = "Plaza Bolognesi, Puerto Maldonado",
                Position = new Position(-12.593785350637601, -69.18683175497507),
                Tag = "id_miubi3",
            };
            MiUbi3.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Green);

            Pin MiUbi4 = new Pin()
            {
                Type = PinType.Place,
                Label = "San Martín",
                Address = "Plaza de armas de Moyobamba, Moyobamba",
                Position = new Position(-6.034524785620219, -76.97473990908789),
                Tag = "id_miubi4",
            };
            MiUbi4.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Green);

            Pin MiUbi5 = new Pin()
            {
                Type = PinType.Place,
                Label = "Ucayali",
                Address = "Plaza de armas de Pucallpa, Pucallpa",
                Position = new Position(-8.383088153044662, -74.53224079133129),
                Tag = "id_miubi5",
            };
            MiUbi5.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Green);

            Pin MiUbi6 = new Pin()
            {
                Type = PinType.Place,
                Label = "Apurimac",
                Address = "Plaza de armas de Abancay, Abancay",
                Position = new Position(-13.637281262515785, -72.87885565748797),
                Tag = "id_miubi6",
            };
            MiUbi6.Icon = BitmapDescriptorFactory.DefaultMarker(Color.BurlyWood);

            Pin MiUbi7 = new Pin()
            {
                Type = PinType.Place,
                Label = "Ayacucho",
                Address = "Plaza Mayor de Huamanga, Ayacucho",
                Position = new Position(-13.160469629198554, -74.22577569833753),
                Tag = "id_miubi7",
            };
            MiUbi7.Icon = BitmapDescriptorFactory.DefaultMarker(Color.BurlyWood);

            Pin MiUbi8 = new Pin()
            {
                Type = PinType.Place,
                Label = "Cajamarca",
                Address = "Plaza de arma de Cajamarca, Cajamarca",
                Position = new Position(-7.156979382405609, -78.51755107586149),
                Tag = "id_miubi8",
            };
            MiUbi8.Icon = BitmapDescriptorFactory.DefaultMarker(Color.BurlyWood);

            Pin MiUbi9 = new Pin()
            {
                Type = PinType.Place,
                Label = "Cusco",
                Address = "Plaza Mayor de Cuzco, Cusco",
                Position = new Position(-13.516712399388346, -71.97873381623644),
                Tag = "id_miubi9",
            };
            MiUbi9.Icon = BitmapDescriptorFactory.DefaultMarker(Color.BurlyWood);

            Pin MiUbi10 = new Pin()
            {
                Type = PinType.Place,
                Label = "Huánuco",
                Address = "Plaza de armas de Huánuco, Huánuco",
                Position = new Position(-9.929475882987159, -76.23969214695073),
                Tag = "id_miubi10",
            };
            MiUbi10.Icon = BitmapDescriptorFactory.DefaultMarker(Color.BurlyWood);

            Pin MiUbi11 = new Pin()
            {
                Type = PinType.Place,
                Label = "Huancavelica",
                Address = "Plaza San Cristobal, Huancavelica",
                Position = new Position(-12.7813130821231, -74.9709563738874),
                Tag = "id_miubi11",
            };
            MiUbi11.Icon = BitmapDescriptorFactory.DefaultMarker(Color.BurlyWood);

            Pin MiUbi12 = new Pin()
            {
                Type = PinType.Place,
                Label = "Junín",
                Address = "Plaza de la Constitución, Huancayo",
                Position = new Position(-12.068087474213865, -75.2100841406689),
                Tag = "id_miubi12",
            };
            MiUbi12.Icon = BitmapDescriptorFactory.DefaultMarker(Color.BurlyWood);

            Pin MiUbi13 = new Pin()
            {
                Type = PinType.Place,
                Label = "La Libertad",
                Address = "Plaza Mayor de Trujillo, Trujillo",
                Position = new Position(-8.111700079029083, -79.02869074923542),
                Tag = "id_miubi13",
            };
            MiUbi13.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            Pin MiUbi14 = new Pin()
            {
                Type = PinType.Place,
                Label = "Pasco",
                Address = "Plaza Daniel Alcides Carrión, Cerro de Pasco",
                Position = new Position(-10.683661785681261, -76.25620657757982),
                Tag = "id_miubi14",
            };
            MiUbi14.Icon = BitmapDescriptorFactory.DefaultMarker(Color.BurlyWood);

            Pin MiUbi15 = new Pin()
            {
                Type = PinType.Place,
                Label = "Puno",
                Address = "Plaza Mayor de Puno, Puno",
                Position = new Position(-15.84053489128154, -70.02791662755776),
                Tag = "id_miubi15",
            };
            MiUbi15.Icon = BitmapDescriptorFactory.DefaultMarker(Color.BurlyWood);

            Pin MiUbi16 = new Pin()
            {
                Type = PinType.Place,
                Label = "Ancash",
                Address = "Plaza de armas de Huaraz, Huaraz",
                Position = new Position(-9.529928803015824, -77.52887546147876),
                Tag = "id_miubi16",
            };
            MiUbi16.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            Pin MiUbi17 = new Pin()
            {
                Type = PinType.Place,
                Label = "Arequipa",
                Address = "Plaza de armas de Arequipa, Arequipa",
                Position = new Position(-16.398760817870013, -71.53690797051301),
                Tag = "id_miubi17",
            };
            MiUbi17.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            Pin MiUbi18 = new Pin()
            {
                Type = PinType.Place,
                Label = "Ica",
                Address = "Plaza de armas de Ica, Ica",
                Position = new Position(-14.06394758357681, -75.72907342601074),
                Tag = "id_miubi18",
            };
            MiUbi18.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            Pin MiUbi19 = new Pin()
            {
                Type = PinType.Place,
                Label = "Lambayeque",
                Address = "Parque principal de Chiclayo, Chiclayo",
                Position = new Position(-6.771561612783808, -79.8387439507087),
                Tag = "id_miubi19",
            };
            MiUbi19.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            Pin MiUbi20 = new Pin()
            {
                Type = PinType.Place,
                Label = "Lima",
                Address = "Plaza San Martín, Lima",
                Position = new Position(-12.051613327747004, -77.03463198144911),
                Tag = "id_miubi20",
            };
            MiUbi20.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            Pin MiUbi21 = new Pin()
            {
                Type = PinType.Place,
                Label = "Moquegua",
                Address = "Plaza de armas de Moquegua, Moquegua",
                Position = new Position(-17.193806721947425, -70.93460844215718),
                Tag = "id_miubi21",
            };
            MiUbi21.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            Pin MiUbi22 = new Pin()
            {
                Type = PinType.Place,
                Label = "Piura",
                Address = "Plaza de armas de Piura, Piura",
                Position = new Position(-5.197163941472542, -80.62664830967573),
                Tag = "id_miubi22",
            };
            MiUbi22.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            Pin MiUbi23 = new Pin()
            {
                Type = PinType.Place,
                Label = "Tacna",
                Address = "Paseo Cívico de Tacna, Tacna",
                Position = new Position(-18.013716907178328, -70.25084992684017),
                Tag = "id_miubi23",
            };
            MiUbi23.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            Pin MiUbi24 = new Pin()
            {
                Type = PinType.Place,
                Label = "Tumbes",
                Address = "Plaza de armas de Tumbes, Tumbes",
                Position = new Position(-3.5708497907129333, -80.4596081669424),
                Tag = "id_miubi24",
            };
            MiUbi24.Icon = BitmapDescriptorFactory.DefaultMarker(Color.Yellow);

            map.Pins.Add(MiUbi1);
            map.Pins.Add(MiUbi2);
            map.Pins.Add(MiUbi3);
            map.Pins.Add(MiUbi4);
            map.Pins.Add(MiUbi5);
            map.Pins.Add(MiUbi6);
            map.Pins.Add(MiUbi7);
            map.Pins.Add(MiUbi8);
            map.Pins.Add(MiUbi9);
            map.Pins.Add(MiUbi10);
            map.Pins.Add(MiUbi11);
            map.Pins.Add(MiUbi12);
            map.Pins.Add(MiUbi13);
            map.Pins.Add(MiUbi14);
            map.Pins.Add(MiUbi15);
            map.Pins.Add(MiUbi16);
            map.Pins.Add(MiUbi17);
            map.Pins.Add(MiUbi18);
            map.Pins.Add(MiUbi19);
            map.Pins.Add(MiUbi20);
            map.Pins.Add(MiUbi21);
            map.Pins.Add(MiUbi22);
            map.Pins.Add(MiUbi23);
            map.Pins.Add(MiUbi24);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi14.Position, Distance.FromKilometers(650)));

            map.PinClicked += OnPinClicked;
        }

        private void OnPinClicked(object sender, PinClickedEventArgs e)
        {
            // Verificar si el Pin seleccionado es MiUbi o MiUbi2
            if (e.Pin != null && (e.Pin.Tag?.ToString() == "id_miubi1" || e.Pin.Tag?.ToString() == "id_miubi2" || e.Pin.Tag?.ToString() == "id_miubi3"
                || e.Pin.Tag?.ToString() == "id_miubi4" || e.Pin.Tag?.ToString() == "id_miubi5" || e.Pin.Tag?.ToString() == "id_miubi6"
                || e.Pin.Tag?.ToString() == "id_miubi7" || e.Pin.Tag?.ToString() == "id_miubi8" || e.Pin.Tag?.ToString() == "id_miubi9"
                || e.Pin.Tag?.ToString() == "id_miubi10" || e.Pin.Tag?.ToString() == "id_miubi11" || e.Pin.Tag?.ToString() == "id_miubi12"
                || e.Pin.Tag?.ToString() == "id_miubi13" || e.Pin.Tag?.ToString() == "id_miubi14" || e.Pin.Tag?.ToString() == "id_miubi15"
                || e.Pin.Tag?.ToString() == "id_miubi16" || e.Pin.Tag?.ToString() == "id_miubi17" || e.Pin.Tag?.ToString() == "id_miubi18"
                || e.Pin.Tag?.ToString() == "id_miubi19" || e.Pin.Tag?.ToString() == "id_miubi20" || e.Pin.Tag?.ToString() == "id_miubi21"
                || e.Pin.Tag?.ToString() == "id_miubi22" || e.Pin.Tag?.ToString() == "id_miubi23" || e.Pin.Tag?.ToString() == "id_miubi24"))
            {
                // Almacenar el pin seleccionado
                selectedPin = e.Pin;

                // Mostrar el botón "Reservar" si se selecciona un Pin válido
                ReservarButton.IsVisible = true;
            }
            else
            {
                // Ocultar el botón "Reservar" si se selecciona un Pin diferente
                ReservarButton.IsVisible = false;
            }
        }

        private void OnReservarClicked(object sender, EventArgs e)
        {
            if (selectedPin != null)
            {
                switch (selectedPin.Tag?.ToString())
                {
                    case "id_miubi1":
                        Navigation.PushAsync(new Amazonas());
                        break;
                    case "id_miubi2":
                        Navigation.PushAsync(new Loreto());
                        break;
                    case "id_miubi3":
                        Navigation.PushAsync(new MadreDeDios());
                        break;
                    case "id_miubi4":
                        Navigation.PushAsync(new SanMartín());
                        break;
                    case "id_miubi5":
                        Navigation.PushAsync(new Ucayali());
                        break;
                    case "id_miubi6":
                        Navigation.PushAsync(new Apurimac());
                        break;
                    case "id_miubi7":
                        Navigation.PushAsync(new Ayacucho());
                        break;
                    case "id_miubi8":
                        Navigation.PushAsync(new Cajamarca());
                        break;
                    case "id_miubi9":
                        Navigation.PushAsync(new Cusco());
                        break;
                    case "id_miubi10":
                        Navigation.PushAsync(new Huanuco());
                        break;
                    case "id_miubi11":
                        Navigation.PushAsync(new Huancavelica());
                        break;
                    case "id_miubi12":
                        Navigation.PushAsync(new Junín());
                        break;
                    case "id_miubi13":
                        Navigation.PushAsync(new LaLibertad());
                        break;
                    case "id_miubi14":
                        Navigation.PushAsync(new Pasco());
                        break;
                    case "id_miubi15":
                        Navigation.PushAsync(new Puno());
                        break;
                    case "id_miubi16":
                        Navigation.PushAsync(new Ancash());
                        break;
                    case "id_miubi17":
                        Navigation.PushAsync(new Arequipa());
                        break;
                    case "id_miubi18":
                        Navigation.PushAsync(new Ica());
                        break;
                    case "id_miubi19":
                        Navigation.PushAsync(new Lambayeque());
                        break;
                    case "id_miubi20":
                        Navigation.PushAsync(new Lima());
                        break;
                    case "id_miubi21":
                        Navigation.PushAsync(new Moquegua());
                        break;
                    case "id_miubi22":
                        Navigation.PushAsync(new Piura());
                        break;
                    case "id_miubi23":
                        Navigation.PushAsync(new Tacna());
                        break;
                    case "id_miubi24":
                        Navigation.PushAsync(new Tumbes());
                        break;
                    // Agrega casos para los demás departamentos aquí
                    default:
                        // Si el Pin no coincide con ninguno de los casos anteriores, no hagas nada
                        break;
                }
            }
        }
    }
}