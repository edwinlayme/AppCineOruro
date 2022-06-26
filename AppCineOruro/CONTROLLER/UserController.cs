using AppCineOruro.MODEL;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCineOruro.CONTROLLER
{
    public class UserController<T>
    {
        public List<Usuario> values = new List<Usuario>();
        Conexion pr;
        IFirebaseClient client;

        public UserController()
        {
            pr = new Conexion();
        }
        public void Adicionar(Usuario nuevo, string ci)
        {
            try
            {
                client = new FireSharp.FirebaseClient(pr.conect);
                client.Set("Usuarios/" + ci, nuevo);
                values.Add(nuevo);
            }
            catch (Exception ex)
            {
                //  res = ex.ToString();
            }
        }
        public List<Usuario> Cargar()
        {
            List<Usuario> users = new List<Usuario>();
            client = new FireSharp.FirebaseClient(pr.conect);
            FirebaseResponse res = client.Get(@"Usuario");
            int cont = int.Parse(res.ResultAs<string>());
            for (int i = 0; i <= cont; i++)
            {
                var result = client.Get("Usuarios");
                Usuario user = result.ResultAs<Usuario>();
                users.Add(user);
            }
            return users;
        }
        public Usuario Buscar(string CI)
        {
            client = new FireSharp.FirebaseClient(pr.conect);
            var result = client.Get("Usuarios/" + CI);
            Usuario user = result.ResultAs<Usuario>();
            return user;
        }
        public void Actualizar(Usuario update,string ci)
        {
            client = new FireSharp.FirebaseClient(pr.conect);
           /* var result = client.Get("Usuarios/" + ci);
            update = result.ResultAs<Usuario>();*/
            client.Update("Usuarios/" + ci, update);
            values.Add(update);
        }
        public void Eliminar(string ci)
        {
            client = new FireSharp.FirebaseClient(pr.conect);
            client.Delete("Usuarios/" + ci);
        }
    }
}
