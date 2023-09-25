using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Demo_MVVM.Models
{

    [Table("Product")]
    public class Product
    {

        [PrimaryKey]
        public int ID { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public double Precio { get; set; }
        public bool Reservar { get; set; }

        public string ImagePath { get; set; }
    }

    
}
