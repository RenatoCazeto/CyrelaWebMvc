using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace CyrelaWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }
        public double TotalDeVendas(DateTime initial , DateTime final)
        {
            return Vendedores.Sum(vendedor => Vendedor.TotalDeVendas(initial, final));
        }
    }
}
