using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class Department
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>();


    


        public Department()
        {
        }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedor.Add(vendedor);
        }

        public double TotalVendas(DateTime ini, DateTime fim)
        {
            return Vendedor.Sum(Vendedor => Vendedor.TotalVendas(ini, fim));
        }
    }
}
