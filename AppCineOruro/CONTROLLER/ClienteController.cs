using AppCineOruro.MODEL;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCineOruro.CONTROLLER
{
    public class ClienteController<T>
    {
        public List<Cliente> values = new List<Cliente>();
        Conexion pr;
        IFirebaseClient cliente;

      public ClienteController()
        {
            pr = new Conexion();
        }
        public void Adicionar(Cliente nuevo, string ci)
        {
            try
            {
                cliente = new FireSharp.FirebaseClient(pr.conect);
                cliente.Set("Clientes/" + ci, nuevo);
                values.Add(nuevo);
            }
            catch (Exception ex)
            {
                //  res = ex.ToString();
            }
        }
        public List<Cliente> Cargar()
        {
            List<Cliente> cls = new List<Cliente>();
            cliente = new FireSharp.FirebaseClient(pr.conect);
            FirebaseResponse res = cliente.Get(@"Clientes");
            int cont = int.Parse(res.ResultAs<string>());
            for (int i = 0; i <= cont; i++)
            {
                var result = cliente.Get("Clientes");
                Cliente cl = result.ResultAs<Cliente>();
                cls.Add(cl);
            }
            return cls;
        }
        public Cliente Buscar(string CI)
        {
            cliente = new FireSharp.FirebaseClient(pr.conect);
            var result = cliente.Get("Clientes/" + CI);
            Cliente user = result.ResultAs<Cliente>();
            return user;
        }
        public void Actualizar(Cliente update,string ci)
        {
            cliente = new FireSharp.FirebaseClient(pr.conect);
            cliente.Update("Clientes/" + ci, update);
            values.Add(update);
        }
        public void Eliminar(string ci)
        {
            cliente = new FireSharp.FirebaseClient(pr.conect);
            cliente.Delete("Clientes/" + ci);
        }
    }
}
