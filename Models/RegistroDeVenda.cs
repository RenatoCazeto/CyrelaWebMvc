using CyrelaWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyrelaWebMvc.Models
{
    public class RegistroDeVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade  { get; set; }
        public StatusDeVenda Status { get; set; }

        public Vendedor Vendedor { get; set; }

        public RegistroDeVenda()
        {

        }

        public RegistroDeVenda(int id, DateTime data, double amount, StatusDeVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = amount;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
