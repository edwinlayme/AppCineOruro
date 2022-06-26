using System;
using System.Collections.Generic;
using System.Text;

namespace AppCineOruro.MODEL
{
    public class Usuario
    { 
        public string ci { get; set; }
        public string nom_usuario { get; set; }
        public string password { get; set; }
        public string nom_completo { get; set; }
        public string email { get; set; }
        public string rol { get; set; }

        public Usuario(string carnet,string nombreCompleto,string user,string contrasena,string correo, string tipo)
        {
            ci = carnet;
            nom_completo=nombreCompleto;
            nom_usuario = user;
            password = contrasena;
            email = correo;
            rol = tipo;
        }
    }
}
