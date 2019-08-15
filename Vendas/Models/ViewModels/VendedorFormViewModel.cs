using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models.ViewModels
{
    public class VendedorFormViewModel
    {
        public Vendedor vendedor { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
