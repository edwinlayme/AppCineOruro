using AppCineOruro.MODEL;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCineOruro.CONTROLLER
{
    public class CarterleraController<T>
    {
        public List<Cartelera> values = new List<Cartelera>();
        Conexion pr;
        IFirebaseClient client;

        public CarterleraController()
        {
            pr = new Conexion();
        }
        public void Adicionar(Cartelera nuevo, string cod)
        {
            try
            {
                client = new FireSharp.FirebaseClient(pr.conect);
                client.Set("Carteleras/" + cod, nuevo);
                values.Add(nuevo);
            }
            catch (Exception ex)
            {
                //  res = ex.ToString();
            }
        }
        public List<Cartelera> Cargar()
        {
            List<Cartelera> users = new List<Cartelera>();
            client = new FireSharp.FirebaseClient(pr.conect);
            FirebaseResponse res = client.Get(@"Carteleras");
            int cont = int.Parse(res.ResultAs<string>());
            for (int i = 0; i <= cont; i++)
            {
                var result = client.Get("Carteleras");
                Cartelera user = result.ResultAs<Cartelera>();
                users.Add(user);
            }
            return users;
        }
        public Cartelera Buscar(string cod)
        {
            client = new FireSharp.FirebaseClient(pr.conect);
            var result = client.Get("Carteleras/" + cod);
            Cartelera user = result.ResultAs<Cartelera>();
            return user;
        }
        public void Actualizar(Cartelera update,string cod)
        {
            client = new FireSharp.FirebaseClient(pr.conect);
           /* var result = client.Get("Usuarios/" + ci);
            update = result.ResultAs<Usuario>();*/
            client.Update("Carteleras/" + cod, update);
            values.Add(update);
        }
        public void Eliminar(string cod)
        {
            client = new FireSharp.FirebaseClient(pr.conect);
            client.Delete("Carteleras/" + cod);
        }
    }
}
