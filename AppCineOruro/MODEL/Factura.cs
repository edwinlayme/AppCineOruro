using System;
using System.Collections.Generic;
using System.Text;

namespace AppCineOruro.MODEL
{
    public class Factura: Boleto
    {
        public int numero { get; set; }
        public string nit_ci { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; } 
        public Factura (int num_factura,string nitci_cliente,string date, string hora_fact,string cod_boleto, int num_asiento, double precio_boleto)
        {
            numero = num_factura;
            nit_ci = nitci_cliente;
            fecha = date;
            hora = hora_fact;
            codigo = cod_boleto;
            asiento = num_asiento;
            precio = precio_boleto;
        }
    }
}
