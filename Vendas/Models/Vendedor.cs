using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class Vendedor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime dtNasc { get; set; }
        public double salario { get; set; }
        public Department department { get; set; }
        public ICollection<Venda> venda { get; set; } = new List<Venda>();


        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dtNasc, double salario, Department department)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.dtNasc = dtNasc;
            this.salario = salario;
            this.department = department;
        }
        public void AddVendas(Venda v)
        {
            venda.Add(v);
        }

        public void RemoverVendas(Venda v)
        {
            venda.Remove(v);
        }

        public double TotalVendas(DateTime ini, DateTime fim)
        {
            return venda.Where(v => v.data >= ini && v.data <= fim).Sum(v => v.total);
        }

    }
}
