using System;
using System.Collections.Generic;
using System.Text;

namespace AppCineOruro.MODEL
{
    public class Cartelera: Pelicula , ISala
    {
        public string codigo { get ; set ; }
        public int capacidad { get ; set ; }

        public Cartelera(string id_pelicula, string nombre_pelicula,
                         string categoria, string desc_pelicula, string formt_pelicula,
                         string origen_pelicula, string anio_estreno,
                         string cod_sala,int cap_sala)
        {
          id = id_pelicula;
          nombre = nombre_pelicula;
          tipo =  categoria;
            descripcion = desc_pelicula;
            formato = formt_pelicula;
            origen = origen_pelicula;
            anio = anio_estreno;
          codigo = cod_sala;
          capacidad = cap_sala; 
          
        }

     }
}
