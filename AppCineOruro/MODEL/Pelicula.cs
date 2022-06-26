using System;
using System.Collections.Generic;
using System.Text;

namespace AppCineOruro.MODEL
{
    public class Pelicula: ISinopsis, ITrailer, IFt
    {
        public string id { get; set; }
        public string nombre{ get; set; }
        public string tipo { get; set; }
        public string descripcion { get; set; }
        public string formato { get; set; }
        public string origen { get; set; }
        public string anio { get; set; }

        public Pelicula()
        {
        }
    }
}
