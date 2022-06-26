using System;
using System.Collections.Generic;
using System.Text;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace AppCineOruro.CONTROLLER
{
    public class Conexion
    {
        public IFirebaseConfig conect;
        public Conexion()
        {
            conect = new FirebaseConfig()
            {
                AuthSecret = "WxktHp7xlmKXUuURu0c3JoVsSiaEaI3PKiX4IjQC",
                BasePath = "https://cineoruro-default-rtdb.firebaseio.com/"
            };

        }
   } 
}
