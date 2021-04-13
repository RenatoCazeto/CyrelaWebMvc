using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace CyrelaWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public double Orcamento { get; set; }

        public DateTime DataSolicitação { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroDeVenda> Vendas { get; set; } = new List<RegistroDeVenda>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, double orcamento, DateTime dataSolicitação, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Orcamento = orcamento;
            DataSolicitação = dataSolicitação;
            Departamento = departamento;
        }

        internal static double TotalDeVendas(DateTime initial, DateTime final)
        {
            throw new NotImplementedException();
        }

        public void AddVendas(RegistroDeVenda sr)
        {
            Vendas.Add(sr);
        }
        public void RemoveVendas(RegistroDeVenda sr)
        {
            Vendas.Remove(sr);
        }
        public double TotalVendas(DateTime initial,DateTime final)
        {
            return Vendas.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Quantidade);
        }
    }

}
