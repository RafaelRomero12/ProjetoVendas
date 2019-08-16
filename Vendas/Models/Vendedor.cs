using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class Vendedor
    {
        public int id { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do {0} é no minimo {2} e o maximo {1} caracteres")]
        public string nome { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [EmailAddress(ErrorMessage = "Insira um E-Mail valido")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dtNasc { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} precisa ser entre {1} e {2}")]
        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double salario { get; set; }

        public Department department { get; set; }

        public int DepartmentId { get; set; }

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
