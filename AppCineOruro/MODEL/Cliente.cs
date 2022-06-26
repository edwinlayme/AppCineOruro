using System;
using System.Collections.Generic;
using System.Text;

namespace AppCineOruro.MODEL
{
    public class Cliente
    {
        public string ci { get; set; }
        public string nom_completo { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public Cliente(string carnet, string nombreCompleto, string correo, string contrasena)
        {
            ci = carnet;
            nom_completo = nombreCompleto;
            email = correo;
            password = contrasena;
        }
    }
}
