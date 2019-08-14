using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models.Enums;

namespace Vendas.Models
{
    public class Venda
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public double total { get; set; }
        public StatusVenda status { get; set; }
        public Vendedor vendedor { get; set; }

        public Venda()
        {
        }

        public Venda(int id, DateTime data, double total, StatusVenda status, Vendedor vendedor)
        {
            this.id = id;
            this.data = data;
            this.total = total;
            this.status = status;
            this.vendedor = vendedor;
        }
    }



}
