using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Demo_MVVM.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Apellidos { get; set; }

        public string Dni { get; set; }
        public string Edad { get; set; }
        public string Email { get; set; }

        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
    }
}
